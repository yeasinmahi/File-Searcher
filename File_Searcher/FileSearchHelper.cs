using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace File_Searcher
{
    public class FileSearchHelper
    {
        public class FileInfo
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public DateTime LastModified { get; set; }
            public string Status { get; set; }
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

                OleDbDataAdapter
                    oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]",
                        con); //here we read data from sheet1  
                oleAdpt.Fill(dtexcel); //fill excel data into dataTable  

            }
            return dtexcel;
        }
        public FileInfo Search(string basePath, string fileName)
        {
            var files = Directory.EnumerateFiles(basePath, fileName, SearchOption.AllDirectories);
            if (files.Any())
            {
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

                return new FileInfo() { FileName = fileName, FilePath = lastModifiedFileName, LastModified = lastModifiedDate, Status = "Success" };
            }
            else
            {
                return new FileInfo() { FileName = fileName, Status = "Not Found" };
            }

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
        public async Task WriteFile(string basePath, string msg)
        {
            try
            {
                var fileName = "log.txt";
                var fullpath = Path.Combine(basePath, fileName);
                FileStream file;
                StreamWriter sw;
                if (!File.Exists(fullpath))
                {
                    if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);
                    try
                    {
                        file = new FileStream(fullpath, FileMode.CreateNew, FileAccess.Write,
                            FileShare.Read);
                        sw = new StreamWriter(file);

                        await sw.WriteLineAsync("FileName \t\tLastModifiedTime \t\tStatus \t\tFilePath");
                        await sw.WriteLineAsync(
                            "=====================================================================================================");
                        sw.Close();
                        file.Close();
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }

                try
                {
                    file = new FileStream(fullpath, FileMode.Append, FileAccess.Write,
                        FileShare.Read);
                    sw = new StreamWriter(file);
                    await sw.WriteLineAsync(msg);
                    sw.Close();
                    file.Close();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public string ToLog(List<FileInfo> fileInfos)
        {
            var message = string.Empty;
            foreach (var fileInfo in fileInfos)
            {
                message += $"{fileInfo.FileName} {fileInfo.LastModified} {fileInfo.Status} {fileInfo.FilePath} \n";
            }
            return message;
        }
    }
}
