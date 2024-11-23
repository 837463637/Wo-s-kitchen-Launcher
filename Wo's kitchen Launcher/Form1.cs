using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MainWindow : Form{

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2", "提示"); // 点击按钮时显示消息框
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void DownloadHomeOperate(object sender, EventArgs e) {
            DownloadHome.Visible = false;
            StartupHome.Visible = false;
            Logo_home_1.Visible = false;
            version_label_home.Visible = true;
            version_bata_1_0_0.Visible = true;
            version_bata_1_0_1.Visible = true;
            version_bata_1_0_2.Visible = true;
            version_bata_label.Visible = true;
            NoDownload.Visible = true;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void NoDownloaHome(object sender, EventArgs e)
        {
            DownloadHome.Visible = true;
            StartupHome.Visible = true;
            Logo_home_1.Visible = true;
            version_label_home.Visible = false;
            version_bata_1_0_0.Visible = false;
            version_bata_1_0_1.Visible = false;
            version_bata_1_0_2.Visible = false;
            version_bata_label.Visible = false;
            NoDownload.Visible = false;
        }
        private async void Download_1_0_0(object sender, EventArgs e)
        {
            MessageBox.Show("请稍等，正在下载！（下载时程序会卡顿）");
            const string url = "https://github.com/837463637/Wo-s-kitchen/releases/download/Game1.0.0bata.zip";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var content = response.Content.ReadAsByteArrayAsync().Result;
            var filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Game1.0.0bata.zip");
            System.IO.File.WriteAllBytes(filePath, content);
            await Task.Delay(1000);
            File.Move("Game1.0.0bata.zip", "C:\\Users\\Administrator\\Desktop\\");
            ZipFile.ExtractToDirectory("Game1.0.0bata.zip", "C:\\Users\\Administrator\\Desktop\\");
            MessageBox.Show("下载完成，请按： 下载Python环境 进行安装！");
        
        }
        private async void Download_1_0_1(object sender, EventArgs e)
        {
            MessageBox.Show("请稍等，正在下载！（下载时程序会卡顿）");
            const string url = "https://github.com/837463637/Wo-s-kitchen/releases/download/Game1.0.1/Game1.0.1bata.zip";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var content = response.Content.ReadAsByteArrayAsync().Result;
            var filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Game1.0.1bata.zip");
            System.IO.File.WriteAllBytes(filePath, content);
            await Task.Delay(1000);
            File.Move("Game1.0.1bata.zip", "C:\\Users\\Administrator\\Desktop\\");
            ZipFile.ExtractToDirectory("Game1.0.1bata.zip", "C:\\Users\\Administrator\\Desktop\\");
            MessageBox.Show("下载完成，请按： 下载Python环境 进行安装！");

        }
        private async void Download_1_0_2(object sender, EventArgs e)
        {
            MessageBox.Show("请稍等，正在下载！（下载时程序会卡顿）");
            const string url = "https://github.com/837463637/Wo-s-kitchen/releases/download/Game1.0.2/Wo-s-kitchen.zip";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var content = response.Content.ReadAsByteArrayAsync().Result;
            var filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Wo-s-kitchen.zip");
            await Task.Delay(1000);
            await Task.Delay(1000);
            File.Move("Game1.0.2bata.zip", "C:\\Users\\Administrator\\Desktop\\");
            ZipFile.ExtractToDirectory("Wo-s-kitchen.zip", "C:\\Users\\Administrator\\Desktop\\");
            MessageBox.Show("下载完成，请按： 下载Python环境 进行安装！");
        }
        private void DownloadPython(object sender, EventArgs e)
        {
            MessageBox.Show("正在下载Python环境，请稍等！（下载时程序会卡顿）");
            const string url = "https://www.python.org/ftp/python/3.9.6/python-3.9.6-amd64.exe";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var content = response.Content.ReadAsByteArrayAsync().Result;
            var filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "python-3.9.6-amd64.exe");
            System.IO.File.WriteAllBytes(filePath, content);
            System.Diagnostics.Process.Start(filePath);
            MessageBox.Show("下载完成,正在下载外部库，请稍等！（下载时程序会卡顿）");
            string batFilePath = "Python.bat";
            Process.Start(batFilePath);
            MessageBox.Show("下载完成，请按： 启动游戏 进行游戏！");
        }
        private void StartGame(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Desktop\\python.exe", "C:\\Users\\Administrator\\Desktop\\main.py");
        }
    }
}