using EapClient.Socket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EapClient.Agent
{
    public delegate void Log(String log);

    class SendDataAgent
    {
        public Log log;

        System.Timers.Timer timer = null;
        string data = null;
        SocketClient sckClient = null;
        string toolID = null;

        public bool IsConnected()
        {
            return sckClient.IsConnected();
        }

        public SendDataAgent(string toolID, double freq)
        {
            //this.freq = freq;
            this.toolID = toolID;
            sckClient = new SocketClient();

            timer = new System.Timers.Timer(freq);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(TimeoutHandler);
            timer.AutoReset = true;
            timer.Enabled = false;
        }

        public void SetData(String data)
        {
            this.data = data;        
        }

        public void Connect(string host, int port) 
        {
            log("Connect : " + host + ":" + port);
            Disconnect();
            try 
            {
                sckClient.Connect(host, port);
                log("Connected");
            }
            catch(Exception e) {
                log("Connect fail ." + e.StackTrace);
                throw e;
            }
            
        }

        public void Disconnect()
        {
            sckClient.Disconnect();
            log("Disconnected");
        }

        public void Start() 
        {
            log("Auto send [Start]");
            timer.Enabled = true;
        }

        public void Stop() 
        {
            log("Auto send [stop]");
            timer.Enabled = false;
        }

        public void SetFreq(double freq) 
        {
            log("Reset Auto Send Freq : " + freq);
            timer.Interval = freq;
        }

        private void TimeoutHandler(object sender, System.Timers.ElapsedEventArgs e)
        {

            SendData(this.data);
            log("Send event");

            Console.WriteLine("timer event");
        }

        public void SendData(string data)
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<SESC>")
                .Append("<TOOL_ID>").Append(this.toolID).Append("</TOOL_ID>")
                .Append("<TIMESTAMP>").Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")).Append("</TIMESTAMP>")
                .Append(data)
                .Append("</SESC></EOF>");
            sckClient.Send(xml.ToString());
        }
    }
}
