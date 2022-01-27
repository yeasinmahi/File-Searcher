using System;
using System.IO;
using System.Windows.Forms;

namespace File_Searcher
{
    public partial class FileSearcher : Form
    {
        public FileSearcher()
        {
            InitializeComponent();
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
            catch(Exception ex)
            {
                ShowMessage(ex.Message);
            }
            
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
