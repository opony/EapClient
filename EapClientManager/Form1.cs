using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EapClientManager
{
    public partial class Form1 : Form
    {
        List<Process> procList = new List<Process>();
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = 8001;
            int clientCnt = Int16.Parse(countTxt.Text);
            ProcessStartInfo startInfo = null;
            Process exeProcess = null;
            for (int i = 0; i < clientCnt; i++)
            {
                startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = fileTxt.Text;
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                //arg : IP:Port EAP1 {freq}
                startInfo.Arguments = ipTxt.Text + ":" + port + " EAP" + (i+1) + " 1000" ;
                Log(startInfo.Arguments);

                exeProcess = Process.Start(startInfo);
                procList.Add(exeProcess);
                Thread.Sleep(1000);
                port++;
            }

            
            ////const string ex1 = @"C:\Eap\Eap1";
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = true;
            ////startInfo.UseShellExecute = false;
            //startInfo.FileName = @"C:\Eap\EapClient.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Normal;
            ////startInfo.Arguments =  ;

            //try
            //{
            //    // Start the process with the info we specified.
            //    // Call WaitForExit and then the using statement will close.
            //    using (Process exeProcess = Process.Start(startInfo))
            //    {
            //        //exeProcess.WaitForExit();
            //    }
            //}
            //catch
            //{
            //    // Log error.
            //}
        }


        private void Log(string msg)
        {
            logTxt.Text = logTxt.Text + msg + "\r\n";
            this.logTxt.SelectionStart = this.logTxt.Text.Length;
            this.logTxt.ScrollToCaret();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileTxt.Text = openFileDialog1.FileName;
            }

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcessesByName("EapClient");
            foreach (Process exeProcess in procList)
            {
                exeProcess.Kill();
            }
            Console.Write("b");
            //foreach (Process exeProcess in procList)
            //{
            //    exeProcess.Kill();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
