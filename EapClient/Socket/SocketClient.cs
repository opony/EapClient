using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EapClient.Socket
{
    

    class SocketClient
    {
        private TcpClient tcpClient = new TcpClient();

        bool isConnected = false;
        NetworkStream stm = null;
        public bool IsConnected()
        {
            return isConnected;
        }
        

        public void Connect(string host, int port)
        {
            if (isConnected)
            {
                Disconnect();
                isConnected = false;
            }

            tcpClient.Connect(host,port);
            stm = tcpClient.GetStream();
            isConnected = true;
        }

        public void Send(string msg) 
        {
            if (!isConnected)
                return;

            if (stm.CanWrite)
            {
                byte[] writeData = Encoding.ASCII.GetBytes(msg);
                stm.Write(writeData, 0, writeData.Length);
            
            }
            
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                tcpClient.Close();
            }

            isConnected = false;
            
        }

    }
}
