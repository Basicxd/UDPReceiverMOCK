using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPReceiverMOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpServer = new UdpClient(7001);

            IPAddress ip = IPAddress.Any;
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 7001);

            try
            {
                Console.WriteLine("Reciever is started");
                while (true)
                {
                    Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                    //Server is now activated");

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);
                    string[] data = receivedData.Split('\n');
                    string data1 = data[0];
                    string data2 = data[1];
                    string data3 = data[2];
                
                    Console.WriteLine(data1);
                    Console.WriteLine(data2);
                    Console.WriteLine(data3);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
