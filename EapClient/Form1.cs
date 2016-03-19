using EapClient.Agent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EapClient
{
    public partial class Form1 : Form
    {
        SendDataAgent agent = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig() {
            XmlReader xmlReader = XmlReader.Create("./Config.xml");
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlReader);
                this.Text = doc.SelectSingleNode("//Config/ToolID").InnerText;

                XmlNode hostNode = doc.SelectSingleNode("//Config/Host");
                string[] tokens = hostNode.InnerText.Split(':');
                hostTxt.Text = tokens[0];
                portTxt.Text = tokens[1];
                XmlNode freqNode = doc.SelectSingleNode("//Config/Freq");
                freqTxt.Text = freqNode.InnerText;

                dataTxt.Text = System.IO.File.ReadAllText(@"./Data.txt");

                
                bool isAutoSend = doc.SelectSingleNode("//Config/AutoSendFlag").InnerText == "1";
                if (isAutoSend)
                {
                    try 
                    {
                        agent = new SendDataAgent(this.Text, double.Parse(freqTxt.Text));
                        agent.log = new Log(DisplayLog);

                        agent.Connect(hostTxt.Text, Int32.Parse(portTxt.Text));
                        ChangeStatus();

                        agent.SetData(dataTxt.Text);
                        agent.Start();

                    }
                    catch (Exception e) 
                    {
                        DisplayLog("auto send fail.");
                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("load config fail : " + ex.StackTrace);
            }
            finally
            {
                doc.Clone();
                xmlReader.Close();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            agent.SetData(dataTxt.Text);
            agent.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            agent.Stop();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            agent.Stop();
            agent.SetFreq(double.Parse(freqTxt.Text));
            agent.SetData(dataTxt.Text);
            agent.Start();
        }

        private void contBtn_Click(object sender, EventArgs e)
        {
            agent = new SendDataAgent(this.Text, double.Parse(freqTxt.Text));
            agent.log = new Log(DisplayLog);
            agent.Connect(hostTxt.Text, Int32.Parse(portTxt.Text));
            ChangeStatus();
        }

        private void ChangeStatus()
        {
            bool enabled = agent.IsConnected();
            contBtn.Enabled = !enabled;
            discontBtn.Enabled = enabled;
            applyBtn.Enabled = enabled;
            startBtn.Enabled = enabled;
            stopBtn.Enabled = enabled;
            sendOnceBtn.Enabled = enabled;

            if (enabled)
            {
                statusLab.Text = "Connected";
                statusLab.BackColor = Color.Green;
            }
            else
            {
                statusLab.Text = "Disconnected";
                statusLab.BackColor = Color.Red;
            }

        }
        private void discontBtn_Click(object sender, EventArgs e)
        {
            agent.Disconnect();
            ChangeStatus();
        }

        public void DisplayLog(string log)
        {
            this.logTxt.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + log + "\r\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agent.SendData(this.dataTxt.Text);
        }
    }
}
