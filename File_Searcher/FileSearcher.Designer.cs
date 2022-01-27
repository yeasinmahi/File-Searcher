namespace File_Searcher
{
    partial class FileSearcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TemplateDownloadBtn = new System.Windows.Forms.Button();
            this.FileUploadBtn = new System.Windows.Forms.Button();
            this.DestinationFolderBtn = new System.Windows.Forms.Button();
            this.SourceFolderBtn = new System.Windows.Forms.Button();
            this.FileUploadTxtBox = new System.Windows.Forms.TextBox();
            this.FileExtentionTxtBox = new System.Windows.Forms.TextBox();
            this.DestinationFolderTxtBox = new System.Windows.Forms.TextBox();
            this.SourceFolderTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TemplateDownloadBtn);
            this.groupBox1.Controls.Add(this.FileUploadBtn);
            this.groupBox1.Controls.Add(this.DestinationFolderBtn);
            this.groupBox1.Controls.Add(this.SourceFolderBtn);
            this.groupBox1.Controls.Add(this.FileUploadTxtBox);
            this.groupBox1.Controls.Add(this.FileExtentionTxtBox);
            this.groupBox1.Controls.Add(this.DestinationFolderTxtBox);
            this.groupBox1.Controls.Add(this.SourceFolderTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // TemplateDownloadBtn
            // 
            this.TemplateDownloadBtn.Location = new System.Drawing.Point(797, 96);
            this.TemplateDownloadBtn.Name = "TemplateDownloadBtn";
            this.TemplateDownloadBtn.Size = new System.Drawing.Size(67, 23);
            this.TemplateDownloadBtn.TabIndex = 2;
            this.TemplateDownloadBtn.Text = "Template";
            this.TemplateDownloadBtn.UseVisualStyleBackColor = true;
            this.TemplateDownloadBtn.Click += new System.EventHandler(this.TemplateDownloadBtn_Click);
            // 
            // FileUploadBtn
            // 
            this.FileUploadBtn.Location = new System.Drawing.Point(725, 96);
            this.FileUploadBtn.Name = "FileUploadBtn";
            this.FileUploadBtn.Size = new System.Drawing.Size(67, 23);
            this.FileUploadBtn.TabIndex = 2;
            this.FileUploadBtn.Text = "Upload";
            this.FileUploadBtn.UseVisualStyleBackColor = true;
            this.FileUploadBtn.Click += new System.EventHandler(this.FileUploadBtn_Click);
            // 
            // DestinationFolderBtn
            // 
            this.DestinationFolderBtn.Location = new System.Drawing.Point(725, 52);
            this.DestinationFolderBtn.Name = "DestinationFolderBtn";
            this.DestinationFolderBtn.Size = new System.Drawing.Size(67, 23);
            this.DestinationFolderBtn.TabIndex = 2;
            this.DestinationFolderBtn.Text = "Browse";
            this.DestinationFolderBtn.UseVisualStyleBackColor = true;
            this.DestinationFolderBtn.Click += new System.EventHandler(this.DestinationFolderBtn_Click);
            // 
            // SourceFolderBtn
            // 
            this.SourceFolderBtn.Location = new System.Drawing.Point(725, 29);
            this.SourceFolderBtn.Name = "SourceFolderBtn";
            this.SourceFolderBtn.Size = new System.Drawing.Size(67, 23);
            this.SourceFolderBtn.TabIndex = 2;
            this.SourceFolderBtn.Text = "Browse";
            this.SourceFolderBtn.UseVisualStyleBackColor = true;
            this.SourceFolderBtn.Click += new System.EventHandler(this.SourceFolderBtn_Click);
            // 
            // FileUploadTxtBox
            // 
            this.FileUploadTxtBox.Location = new System.Drawing.Point(117, 98);
            this.FileUploadTxtBox.Name = "FileUploadTxtBox";
            this.FileUploadTxtBox.Size = new System.Drawing.Size(602, 20);
            this.FileUploadTxtBox.TabIndex = 1;
            // 
            // FileExtentionTxtBox
            // 
            this.FileExtentionTxtBox.Location = new System.Drawing.Point(117, 76);
            this.FileExtentionTxtBox.Name = "FileExtentionTxtBox";
            this.FileExtentionTxtBox.ReadOnly = true;
            this.FileExtentionTxtBox.Size = new System.Drawing.Size(313, 20);
            this.FileExtentionTxtBox.TabIndex = 1;
            this.FileExtentionTxtBox.Text = ".Pdf";
            // 
            // DestinationFolderTxtBox
            // 
            this.DestinationFolderTxtBox.Location = new System.Drawing.Point(117, 54);
            this.DestinationFolderTxtBox.Name = "DestinationFolderTxtBox";
            this.DestinationFolderTxtBox.Size = new System.Drawing.Size(602, 20);
            this.DestinationFolderTxtBox.TabIndex = 1;
            // 
            // SourceFolderTxtBox
            // 
            this.SourceFolderTxtBox.Location = new System.Drawing.Point(117, 31);
            this.SourceFolderTxtBox.Name = "SourceFolderTxtBox";
            this.SourceFolderTxtBox.Size = new System.Drawing.Size(602, 20);
            this.SourceFolderTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Extention";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel Workbook (*.xlsx)|*.xlsx|csv(*.csv)|*.csv";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 97-2003 (*.xls)|*.xls|csv(*.csv)|*.csv";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // FileSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 514);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileSearcher";
            this.Text = "File Searcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileUploadTxtBox;
        private System.Windows.Forms.TextBox FileExtentionTxtBox;
        private System.Windows.Forms.TextBox DestinationFolderTxtBox;
        private System.Windows.Forms.TextBox SourceFolderTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SourceFolderBtn;
        private System.Windows.Forms.Button FileUploadBtn;
        private System.Windows.Forms.Button DestinationFolderBtn;
        private System.Windows.Forms.Button TemplateDownloadBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

