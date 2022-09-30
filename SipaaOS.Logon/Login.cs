using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaOS.Logon
{
    public partial class Login : Form
    {
        string username;
        string password;
        public Login()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Configuration\\SODE.cfg"))
            {
                string[] sodecfg = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Configuration\\SODE");
                if (File.Exists(sodecfg[2].Replace("BackgroundFile=", "")))
                {
                    this.BackgroundImage = Image.FromFile(sodecfg[2].Replace("BackgroundFile=", ""));
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Configuration\\USER.cfg"))
            {
                string[] fileinfo = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Configuration\\USER.cfg");
                username = fileinfo[2].Replace("Username=","");
                if (fileinfo[3].Replace("Password=", "") == "Nothing")
                {
                    password = "";
                }
                else
                {
                    password = fileinfo[3].Replace("Password=", "");
                }
            }
            else
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Configuration"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Configuration");
                }
                StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Configuration\\USER.cfg");
                writer.WriteLine("SipaaOS User Info File");
                writer.WriteLine("---------------------------------------------------");
                writer.WriteLine("Username=SipaaOSUser");
                writer.WriteLine("Password=Nothing");
                writer.Close();

                string[] fileinfo = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Configuration\\USER.cfg");
                username = fileinfo[2].Replace("Username=", "");
                if (fileinfo[3].Replace("Password=", "") == "Nothing")
                {
                    password = "";
                }
                else
                {
                    password = fileinfo[3].Replace("Password=", "");
                }
            }
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == password)
            {
                Process process = new Process();
                process.StartInfo.FileName = "sipaasode.exe";
                process.StartInfo.Arguments = "--loggedFromLoginUI=true";
                process.Start();
            } else
            {
                textBox1.Clear();
                MessageBox.Show("Im sorry but you password is incorrect");
            }
        }
    }
}
