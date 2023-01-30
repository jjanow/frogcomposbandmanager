using System.Diagnostics;

namespace FrogcomposbandManager
{
    public partial class Form1 : Form
    {
        public string[]? SaveFiles { get; set; }
        public string SavePath { get; set; } = @"C:\Games\Frogcomposband\lib\save\";
        public string BackupPath { get; set; } = @"C:\Games\Frogcomposband\lib\save\backup\";
        public string ExePath { get; set; } = @"C:\Games\Frogcomposband\frogcomposband.exe";

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshFileList()
        {
            lbSaves.Items.Clear();
            SaveFiles = Directory.GetFiles(SavePath);

            foreach (string file in SaveFiles)
            {
                if (File.Exists(file))
                {
                    lbSaves.Items.Add(file.Split("\\").Last().Trim());
                }
            }

            if (lbSaves.Items.Count > 0)
            {
                lbSaves.SelectedItem = lbSaves.Items[0];
            }

            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshFileList();
        }

        private void btnRefreshSaves_Click(object sender, EventArgs e)
        {
            RefreshFileList();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            File.Copy(SavePath + lbSaves.SelectedItem, BackupPath + lbSaves.SelectedItem, true);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            File.Copy(BackupPath + lbSaves.SelectedItem, SavePath + lbSaves.SelectedItem, true);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = ExePath;
            process.StartInfo.Arguments = lbSaves.SelectedItem.ToString();
            process.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete(SavePath + lbSaves.SelectedItem);
            File.Delete(BackupPath + lbSaves.SelectedItem);
            RefreshFileList();
        }
    }
}