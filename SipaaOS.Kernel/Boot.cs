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

namespace SipaaOS.Kernel
{
    public partial class Boot : Form
    {
        public Boot()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, label1.Location.Y);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, label2.Location.Y);
            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2, pictureBox1.Location.Y);
            if (KernelBase.recoverymode == true)
            {
                label2.Visible = true;
            } else
            {
                label2.Visible = false;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                if (KernelBase.recoverymode == true)
                {
                    RecEnv recEnv = new RecEnv();
                    recEnv.TopLevel = false;
                    this.Controls.Add(recEnv);
                    recEnv.Show();
                    timer1.Stop();
                } else
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = "silogonui.exe";
                    try
                    {
                        proc.Start();
                        timer1.Stop();
                    } catch (System.ComponentModel.Win32Exception)
                    {
                        timer1.Stop();
                        MessageBox.Show("silogonui.exe not found. Try redownload silogonui.exe from official SipaaOS Github.");
                        Console.WriteLine("IOException : silogonui.exe not found");
                        Environment.Exit(1);
                    }
                }
            }
        }
    }
}
