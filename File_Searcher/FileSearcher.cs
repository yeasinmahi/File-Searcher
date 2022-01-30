using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace File_Searcher
{
    public partial class FileSearcher : Form
    {
        List<string> _fileNames = new List<string>();
        public FileSearcher()
        {
            InitializeComponent();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void SourceFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SourceFolderTxtBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DestinationFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                DestinationFolderTxtBox.Text = folderBrowserDialog2.SelectedPath;
            }
        }
        private void FileUploadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileUploadTxtBox.Text = openFileDialog1.FileName;
            }
        }
        private void FileUploadTxtBox_TextChanged(object sender, EventArgs e)
        {
            var filePath = FileUploadTxtBox.Text;
            try
            {
                if (File.Exists(filePath))
                {
                    string extension = Path.GetExtension(filePath);
                    if (extension.ToLower().Equals(".xls") || extension.ToLower().Equals(".xlsx"))
                    {
                        var dt = ReadExcel(filePath, extension);

                        dataGridView.DataSource = dt;
                        _fileNames = ToList(dt);
                    }
                    else
                    {
                        ShowMessage("No Excel file found.");
                    }
                }
                else
                {
                    ShowMessage("No file exist in your selected location");
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }
        private void TemplateDownloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var basePath = Directory.GetParent(Application.StartupPath)?.Parent?.FullName;
                    if (basePath != null)
                    {
                        var destinationPath = saveFileDialog1.FileName;
                        var extension = Path.GetExtension(destinationPath);
                        if (extension != null)
                        {
                            var fullPath = Path.Combine(basePath, @"Data\Templete" + extension);
                            var bytes = File.ReadAllBytes(fullPath);
                            File.WriteAllBytes(destinationPath, bytes);
                            ShowMessage("Successfully Downloaded.");
                        }
                        else
                        {
                            ShowMessage("No valid file extension found.");
                        }
                    }
                    else
                    {
                        ShowMessage("Something error in the template source path.");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            List<FileInfo> fileInfos = new List<FileInfo>();
            //string sourcePath = @"C:\Users\Yeasin\Downloads\FileSearcher";
            //string destinationPath = @"C:\Users\Yeasin\Downloads\Destination";
            //string filePath = @"C:\Users\Yeasin\Downloads\FileSearcher\test.xls";

            string sourcePath = SourceFolderTxtBox.Text;
            string destinationPath = DestinationFolderTxtBox.Text;
            string filePath = FileUploadTxtBox.Text;

            if (!IsValid(sourcePath, destinationPath, filePath))
            {
                return;
            }


            foreach (var fileName in _fileNames)
            {
                var fileInfo = Search(sourcePath, fileName);
                string destinationFullPath = destinationPath + "\\" + fileInfo.FileName;
                if (File.Exists(destinationFullPath))
                {
                    DateTime lastModifyDate = new DirectoryInfo(destinationFullPath).LastWriteTime;
                    if (lastModifyDate > fileInfo.LastModified)
                    {
                        fileInfo.FilePath = destinationFullPath;
                        fileInfo.LastModified = new DirectoryInfo(destinationFullPath).LastWriteTime;
                    }
                    else
                    {
                        File.Copy(fileInfo.FilePath, destinationFullPath, true);
                    }

                }
                else
                {
                    File.Copy(fileInfo.FilePath, destinationFullPath);
                }

                fileInfos.Add(fileInfo);

                dataGridView.DataSource = fileInfos;
                ShowMessage("Successfully Copied");
            }
        }
        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn;
            DataTable dtexcel = new DataTable();
            if (string.Compare(fileExt, ".xls", StringComparison.Ordinal) == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter
                        oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]",
                            con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message);
                }
            }
            return dtexcel;
        }

        public List<string> ToList(DataTable dt)
        {
            var fileNames = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string name = row.ItemArray[0].ToString();
                if (!string.IsNullOrWhiteSpace(name))
                    fileNames.Add(name + ".pdf");
            }
            return fileNames;
        }

        public List<FileInfo> Debug(string basePath, string fileName)
        {
            List<FileInfo> fileInfos = new List<FileInfo>();
            var files = Directory.EnumerateFiles(basePath, fileName, SearchOption.AllDirectories);
            foreach (string file in files)
            {
                fileInfos.Add(new FileInfo() { FileName = fileName, FilePath = file, LastModified = new DirectoryInfo(file).LastWriteTime });
            }

            return fileInfos;
        }

        public FileInfo Search(string basePath, string fileName)
        {
            var files = Directory.EnumerateFiles(basePath, fileName, SearchOption.AllDirectories);
            DateTime lastModifiedDate = DateTime.MinValue;
            string lastModifiedFileName = String.Empty;
            foreach (string file in files)
            {
                DateTime fileDate = new DirectoryInfo(file).LastWriteTime;
                if (lastModifiedDate < fileDate)
                {
                    lastModifiedDate = fileDate;
                    lastModifiedFileName = file;
                }
            }

            return new FileInfo() { FileName = fileName, FilePath = lastModifiedFileName, LastModified = lastModifiedDate };
        }
        public class FileInfo
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public DateTime LastModified { get; set; }
        }

        public bool IsValid(string sourcePath, string destinationPath, string filePath)
        {
            if (string.IsNullOrWhiteSpace(sourcePath))
            {
                ShowMessage("Source Path can not be empty");
                return false;
            }
            if (string.IsNullOrWhiteSpace(destinationPath))
            {
                ShowMessage("Destination Path can not be empty");
                return false;
            }
            if (string.IsNullOrWhiteSpace(filePath))
            {
                ShowMessage("A excel file with proper template should be selected for search");
                return false;
            }
            if (destinationPath.Contains(sourcePath))
            {
                ShowMessage("Destination Path can not be the part of source path");
                return false;
            }

            return true;
        }

        
    }
}
