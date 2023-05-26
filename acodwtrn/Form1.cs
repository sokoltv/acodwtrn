using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Resources;

namespace acodwtrn
{
    public partial class Form1 : Form
    {
        
        private string adminProgramPath = "";
        private string userProgramPath = "";

        private const string cfgFile = "Settings.json";

        private const string _lb = "Selected ";
        private const string _UNchooseProg = "Program not selected ";
        private const string _chooseProg = "Selected ";
        private const string _proStart = "The program is running as ";
        private const string _admin = "Admin";
        private const string _user = "User";
        private const string _error = "Error when launching software as";

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(cfgFile))
            {
                string jsonString = File.ReadAllText(cfgFile);
                var config = JsonSerializer.Deserialize<Config>(jsonString);

                adminProgramPath = config.APP;
                userProgramPath = config.UPP;

                UpdateLabels();
            }
        }

        // Selecting a program to run as admin
        private void button1_Click(object sender, EventArgs e)
        {


            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    adminProgramPath = dialog.FileName;
                    adminProg.Text = _lb + adminProgramPath;
                    SaveCFG();
                }
            }
        }
        // Junk not removed
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Selecting a program to run as a user
        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    userProgramPath = dialog.FileName;
                    userProg.Text = _lb + userProgramPath;
                    SaveCFG();
                }
            }
        }
        // launch
        private void button3_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(adminProgramPath))
            {
                try
                {
                    ProcessStartInfo adminProccesSI = new ProcessStartInfo(adminProgramPath);
                    adminProccesSI.Verb = "runas";
                    Process.Start(adminProccesSI);
                    adminStatusLabel.Text = _proStart + _admin;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(_error + _admin + ex.Message);
                }
            }

            

            if (!string.IsNullOrEmpty(userProgramPath))
            {
                try
                {
                    Thread.Sleep(10000);
                    ProcessStartInfo userProccesSI = new ProcessStartInfo(userProgramPath);
                    userProccesSI.Verb = "runas";
                    Process.Start(userProccesSI);
                    userProgrammLabel.Text = _proStart + _user;

                    Thread.Sleep(5000);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(_error + _user + ex.Message);
                }
            }
            
        }

        private void SaveCFG()
        {
            var config = new Config
            {
                APP = adminProgramPath,
                UPP = userProgramPath
            };

            string jsonString = JsonSerializer.Serialize(config);
            File.WriteAllText(cfgFile, jsonString);
        }

        private void UpdateLabels()
        {
            adminProg.Text = string.IsNullOrEmpty(adminProgramPath) ? _UNchooseProg : _chooseProg + Path.GetFileName(adminProgramPath);
            userProg.Text = string.IsNullOrEmpty(userProgramPath) ? _UNchooseProg : _chooseProg + Path.GetFileName(userProgramPath);
        }

        public class Config
        {
            public string APP { get; set; }
            public string UPP { get; set; }
        }
    }
}
