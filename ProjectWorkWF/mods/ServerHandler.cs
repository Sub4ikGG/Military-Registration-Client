using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWorkWF.mods
{
    public class ServerHandler
    {
        FormsHandler fHandler = new FormsHandler();
        private NetworkStream stream;

        public ServerHandler(NetworkStream stream)
        {
            this.stream = stream;
        }

        public void SendRequest(string request)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
            catch (Exception e)
            {
                fHandler.ShowError($"Непредвиденная ошибка.\n{e.Message}");
            }
        }

        public string WaitingResult()
        {
            try
            {
                byte[] bufferResult = new byte[256];
                int length = stream.Read(bufferResult, 0, bufferResult.Length);
                string answer = Encoding.UTF8.GetString(bufferResult, 0, length).Trim();

                return answer;
            }
            catch (Exception e)
            {
                fHandler.ShowError($"Непредвиденная ошибка.\n{e.Message}");

                return "";
            }
        }
    }
}
