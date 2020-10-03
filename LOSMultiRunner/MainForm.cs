using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LOSMultiRunner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialog.SelectedPath + "\\LOS.exe"))
                    LOSDir.Text = folderBrowserDialog.SelectedPath;
                else
                    MessageBox.Show("Choose a correct game directory");
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if(!File.Exists(LOSDir.Text + "\\LOS.exe"))
            {
                MessageBox.Show("Choose a correct game directory");
            }
            else
            {
                byte[] LOSexe = File.ReadAllBytes(LOSDir.Text + "\\LOS.exe");
                string mutex = "program404";

                int index = SearchBytes(LOSexe, System.Text.Encoding.Default.GetBytes(mutex));

                for (int i = 0; i < mutex.Length; i++)
                    LOSexe[index + i] = 0;

                for (int instancesCount = 0; ; instancesCount++)
                {
                    try
                    {
                        File.WriteAllBytes(LOSDir.Text + "\\LOS" + instancesCount + ".exe", LOSexe);
                        ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/min /C \"set __COMPAT_LAYER=RUNASINVOKER && " + LOSDir.Text.Split(':')[0] + ": && cd " + LOSDir.Text + " && " + "start LOS" + instancesCount + ".exe CDLDKJFRE342LDLSL39\"");
                        processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        Process.Start(processStartInfo);
                        break;
                    }
                    catch { }
                }

                Application.Exit();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["LOSDir"] = LOSDir.Text;
            Properties.Settings.Default.Save();
        }

        private void CleanUp_Click(object sender, EventArgs e)
        {
            if (!File.Exists(LOSDir.Text + "\\LOS.exe"))
            {
                MessageBox.Show("Choose a correct game directory");
            }
            else
            {
                string[] filesToDelete = Directory.GetFiles(LOSDir.Text, "LOS*.exe");

                for (int i = 0; i < filesToDelete.Length; i++)
                {
                    try
                    {
                        File.Delete(LOSDir.Text + "\\LOS" + i + ".exe");
                    }
                    catch
                    {
                        MessageBox.Show("Please close all game instances to run correctly");
                    }
                }
            }
        }

        private int SearchBytes(byte[] arr, byte[] subarr)
        {
            for (var i = 0; i <= arr.Length - subarr.Length; i++)
            {
                var k = 0;

                for (; k < subarr.Length; k++)
                    if (subarr[k] != arr[i + k])
                        break;
                
                if (k == subarr.Length)
                    return i;
            }

            return -1;
        }
    }
}
