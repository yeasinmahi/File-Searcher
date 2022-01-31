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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSearcher));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TemplateDownloadBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FileUploadBtn = new System.Windows.Forms.Button();
            this.DestinationFolderBtn = new System.Windows.Forms.Button();
            this.SourceFolderBtn = new System.Windows.Forms.Button();
            this.FileUploadTxtBox = new System.Windows.Forms.TextBox();
            this.DestinationFolderTxtBox = new System.Windows.Forms.TextBox();
            this.SourceFolderTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.TemplateDownloadBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.FileUploadBtn);
            this.groupBox1.Controls.Add(this.DestinationFolderBtn);
            this.groupBox1.Controls.Add(this.SourceFolderBtn);
            this.groupBox1.Controls.Add(this.FileUploadTxtBox);
            this.groupBox1.Controls.Add(this.DestinationFolderTxtBox);
            this.groupBox1.Controls.Add(this.SourceFolderTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(117, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(601, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // TemplateDownloadBtn
            // 
            this.TemplateDownloadBtn.Location = new System.Drawing.Point(813, 77);
            this.TemplateDownloadBtn.Name = "TemplateDownloadBtn";
            this.TemplateDownloadBtn.Size = new System.Drawing.Size(67, 23);
            this.TemplateDownloadBtn.TabIndex = 2;
            this.TemplateDownloadBtn.Text = "Template";
            this.TemplateDownloadBtn.UseVisualStyleBackColor = true;
            this.TemplateDownloadBtn.Click += new System.EventHandler(this.TemplateDownloadBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(13, 121);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(67, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FileUploadBtn
            // 
            this.FileUploadBtn.Location = new System.Drawing.Point(741, 77);
            this.FileUploadBtn.Name = "FileUploadBtn";
            this.FileUploadBtn.Size = new System.Drawing.Size(67, 23);
            this.FileUploadBtn.TabIndex = 2;
            this.FileUploadBtn.Text = "Upload";
            this.FileUploadBtn.UseVisualStyleBackColor = true;
            this.FileUploadBtn.Click += new System.EventHandler(this.FileUploadBtn_Click);
            // 
            // DestinationFolderBtn
            // 
            this.DestinationFolderBtn.Location = new System.Drawing.Point(741, 51);
            this.DestinationFolderBtn.Name = "DestinationFolderBtn";
            this.DestinationFolderBtn.Size = new System.Drawing.Size(67, 23);
            this.DestinationFolderBtn.TabIndex = 2;
            this.DestinationFolderBtn.Text = "Browse";
            this.DestinationFolderBtn.UseVisualStyleBackColor = true;
            this.DestinationFolderBtn.Click += new System.EventHandler(this.DestinationFolderBtn_Click);
            // 
            // SourceFolderBtn
            // 
            this.SourceFolderBtn.Location = new System.Drawing.Point(741, 28);
            this.SourceFolderBtn.Name = "SourceFolderBtn";
            this.SourceFolderBtn.Size = new System.Drawing.Size(67, 23);
            this.SourceFolderBtn.TabIndex = 2;
            this.SourceFolderBtn.Text = "Browse";
            this.SourceFolderBtn.UseVisualStyleBackColor = true;
            this.SourceFolderBtn.Click += new System.EventHandler(this.SourceFolderBtn_Click);
            // 
            // FileUploadTxtBox
            // 
            this.FileUploadTxtBox.Location = new System.Drawing.Point(117, 80);
            this.FileUploadTxtBox.Name = "FileUploadTxtBox";
            this.FileUploadTxtBox.Size = new System.Drawing.Size(601, 20);
            this.FileUploadTxtBox.TabIndex = 1;
            this.FileUploadTxtBox.TextChanged += new System.EventHandler(this.FileUploadTxtBox_TextChanged);
            // 
            // DestinationFolderTxtBox
            // 
            this.DestinationFolderTxtBox.Location = new System.Drawing.Point(117, 54);
            this.DestinationFolderTxtBox.Name = "DestinationFolderTxtBox";
            this.DestinationFolderTxtBox.Size = new System.Drawing.Size(601, 20);
            this.DestinationFolderTxtBox.TabIndex = 1;
            // 
            // SourceFolderTxtBox
            // 
            this.SourceFolderTxtBox.Location = new System.Drawing.Point(117, 31);
            this.SourceFolderTxtBox.Name = "SourceFolderTxtBox";
            this.SourceFolderTxtBox.Size = new System.Drawing.Size(601, 20);
            this.SourceFolderTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "File";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(714, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(714, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(714, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel Workbook (*.xlsx)|*.xlsx";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 97-2003 (*.xls)|*.xls";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(879, 287);
            this.dataGridView.TabIndex = 1;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(825, 180);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(75, 23);
            this.DownloadBtn.TabIndex = 2;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FileSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 514);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileSearcher";
            this.Text = "File Searcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileUploadTxtBox;
        private System.Windows.Forms.TextBox DestinationFolderTxtBox;
        private System.Windows.Forms.TextBox SourceFolderTxtBox;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

