namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Logo_home_1 = new System.Windows.Forms.Label();
            this.DownloadHome = new System.Windows.Forms.Button();
            this.StartupHome = new System.Windows.Forms.Button();
            this.version_bata_1_0_0 = new System.Windows.Forms.Button();
            this.version_label_home = new System.Windows.Forms.Label();
            this.version_bata_1_0_1 = new System.Windows.Forms.Button();
            this.version_bata_1_0_2 = new System.Windows.Forms.Button();
            this.version_bata_label = new System.Windows.Forms.Label();
            this.NoDownload = new System.Windows.Forms.Button();
            this.Download_home_Python = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logo_home_1
            // 
            resources.ApplyResources(this.Logo_home_1, "Logo_home_1");
            this.Logo_home_1.BackColor = System.Drawing.Color.Transparent;
            this.Logo_home_1.Name = "Logo_home_1";
            // 
            // DownloadHome
            // 
            resources.ApplyResources(this.DownloadHome, "DownloadHome");
            this.DownloadHome.Name = "DownloadHome";
            this.DownloadHome.UseVisualStyleBackColor = true;
            this.DownloadHome.Click += new System.EventHandler(this.DownloadHomeOperate);
            // 
            // StartupHome
            // 
            resources.ApplyResources(this.StartupHome, "StartupHome");
            this.StartupHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartupHome.Name = "StartupHome";
            this.StartupHome.UseVisualStyleBackColor = true;
            this.StartupHome.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // version_bata_1_0_0
            // 
            this.version_bata_1_0_0.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.version_bata_1_0_0, "version_bata_1_0_0");
            this.version_bata_1_0_0.Name = "version_bata_1_0_0";
            this.version_bata_1_0_0.UseVisualStyleBackColor = false;
            this.version_bata_1_0_0.Click += new System.EventHandler(this.Download_1_0_0);
            // 
            // version_label_home
            // 
            resources.ApplyResources(this.version_label_home, "version_label_home");
            this.version_label_home.BackColor = System.Drawing.Color.Transparent;
            this.version_label_home.Name = "version_label_home";
            this.version_label_home.Click += new System.EventHandler(this.label1_Click);
            // 
            // version_bata_1_0_1
            // 
            resources.ApplyResources(this.version_bata_1_0_1, "version_bata_1_0_1");
            this.version_bata_1_0_1.Name = "version_bata_1_0_1";
            this.version_bata_1_0_1.UseVisualStyleBackColor = true;
            this.version_bata_1_0_1.Click += new System.EventHandler(this.Download_1_0_1);
            // 
            // version_bata_1_0_2
            // 
            this.version_bata_1_0_2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.version_bata_1_0_2, "version_bata_1_0_2");
            this.version_bata_1_0_2.Name = "version_bata_1_0_2";
            this.version_bata_1_0_2.UseVisualStyleBackColor = false;
            this.version_bata_1_0_2.Click += new System.EventHandler(this.Download_1_0_2);
            // 
            // version_bata_label
            // 
            resources.ApplyResources(this.version_bata_label, "version_bata_label");
            this.version_bata_label.BackColor = System.Drawing.Color.Transparent;
            this.version_bata_label.Name = "version_bata_label";
            // 
            // NoDownload
            // 
            resources.ApplyResources(this.NoDownload, "NoDownload");
            this.NoDownload.Name = "NoDownload";
            this.NoDownload.UseVisualStyleBackColor = true;
            this.NoDownload.Click += new System.EventHandler(this.NoDownloaHome);
            // 
            // Download_home_Python
            // 
            resources.ApplyResources(this.Download_home_Python, "Download_home_Python");
            this.Download_home_Python.Name = "Download_home_Python";
            this.Download_home_Python.UseVisualStyleBackColor = true;
            this.Download_home_Python.Click += new System.EventHandler(this.DownloadPython);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Download_home_Python);
            this.Controls.Add(this.NoDownload);
            this.Controls.Add(this.version_bata_label);
            this.Controls.Add(this.version_bata_1_0_2);
            this.Controls.Add(this.version_bata_1_0_1);
            this.Controls.Add(this.version_label_home);
            this.Controls.Add(this.version_bata_1_0_0);
            this.Controls.Add(this.StartupHome);
            this.Controls.Add(this.DownloadHome);
            this.Controls.Add(this.Logo_home_1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo_home_1;
        private System.Windows.Forms.Button DownloadHome;
        private System.Windows.Forms.Button StartupHome;
        private System.Windows.Forms.Button version_bata_1_0_0;
        private System.Windows.Forms.Label version_label_home;
        private System.Windows.Forms.Button version_bata_1_0_1;
        private System.Windows.Forms.Button version_bata_1_0_2;
        private System.Windows.Forms.Label version_bata_label;
        private System.Windows.Forms.Button NoDownload;
        private System.Windows.Forms.Button Download_home_Python;
    }
}

