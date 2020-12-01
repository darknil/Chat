using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WPFChat
{
    /// <summary>
    /// Грустный клиент
    /// </summary>
    class Client
    {
        //Для особенных
        //Заебал
        //sam zaebal
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void Main(string[] args)
        {

           


            socket.Connect("127.0.0.1",8080);

            Console.ReadLine();
            
        }
    }
    
}
