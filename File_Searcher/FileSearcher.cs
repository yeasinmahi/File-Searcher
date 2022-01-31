using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace File_Searcher
{
    public partial class FileSearcher : Form
    {
        private List<string> _fileNames = new List<string>();
        private readonly List<FileSearchHelper.FileInfo> _fileInfos = new List<FileSearchHelper.FileInfo>();
        private readonly FileSearchHelper _helper = new FileSearchHelper();
        public FileSearcher()
        {
            InitializeComponent();
            SourceFolderTxtBox.Text= ConfigurationManager.AppSettings["sourcePath"];
            DestinationFolderTxtBox.Text= ConfigurationManager.AppSettings["destinationPath"];
            FileUploadTxtBox.Text= ConfigurationManager.AppSettings["filePath"];
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
                        var dt = _helper.ReadExcel(filePath, extension);

                        dataGridView.DataSource = dt;
                        _fileNames = _helper.ToList(dt);
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
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            backgroundWorker.RunWorkerAsync();
            
            
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
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_fileInfos.Count > 0)
                {
                    var path = DestinationFolderTxtBox.Text;
                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        _ = _helper.WriteFile(path, _helper.ToLog(_fileInfos));
                        ShowMessage("File downloaded successfully");
                    }
                    else
                    {
                        ShowMessage("No destination path selected to download");
                    }
                }
                else
                {
                    ShowMessage("No log found to download.");
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
            
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
           
            try
            {
                string sourcePath = SourceFolderTxtBox.Text;
                string destinationPath = DestinationFolderTxtBox.Text;
                string filePath = FileUploadTxtBox.Text;
                _fileInfos.Clear();
                if (!IsValid(sourcePath, destinationPath, filePath))
                {
                    return;
                }

                int counter = 0;
                
                foreach (var fileName in _fileNames)
                {
                    var fileInfo = _helper.Search(sourcePath, fileName);
                    if (fileInfo.Status.Equals("Success"))
                    {
                        string destinationFullPath = destinationPath + "\\" + fileInfo.FileName;
                        if (File.Exists(destinationFullPath))
                        {
                            //DateTime lastModifyDate = new DirectoryInfo(destinationFullPath).LastWriteTime;
                            //if (lastModifyDate > fileInfo.LastModified)
                            //{
                            //    fileInfo.FilePath = destinationFullPath;
                            //    fileInfo.LastModified = new DirectoryInfo(destinationFullPath).LastWriteTime;
                            //}
                            //else
                            //{
                            //    File.Copy(fileInfo.FilePath, destinationFullPath, true);
                            //}
                            fileInfo.Status = "File Exist";
                        }
                        else
                        {
                            File.Copy(fileInfo.FilePath, destinationFullPath);
                        }


                    }
                    else
                    {

                    }

                    _fileInfos.Add(fileInfo);
                    counter++;
                    worker.ReportProgress(counter * 100 / _fileNames.Count);
                }
                
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView.DataSource = _fileInfos;
            if (_fileInfos.Count > 0)
            {
                ShowMessage("File search completed");
            }
        }
    }
}
