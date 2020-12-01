using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace server
{
    class server
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void Main(string[] args)
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8080);

            listener.Listen(5);

            Socket client = socket.Accept();
            Console.WriteLine("подключение");
            Console.ReadLine();
        }
        //static void Main(string[] args)
        //{
        //    // Устанавливаем для сокета локальную конечную точку
        //    IPHostEntry ipHost = Dns.GetHostEntry("localhost");
        //    IPAddress ipAddr = ipHost.AddressList[0];
        //    IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

        //    // Создаем сокет Tcp/Ip
        //    Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        //    // Назначаем сокет локальной конечной точке и слушаем входящие сокеты


        //    sListener.Bind(ipEndPoint);
        //    sListener.Listen(10);
        //    Console.ReadLine();

        //}
    }
}
