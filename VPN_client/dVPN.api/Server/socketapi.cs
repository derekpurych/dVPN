using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography;
using System.IO;

using dVPN.HttpStyleUriParser;

public class NetworkStream : System.IO.Stream

    public NetworkStream (System.Net.Sockets.Socket socket);

    public NetworkStream (System.Net.Sockets.Socket socket, System.IO.FileAccess access);



















namespace Mssc.TransportProtocols.Utilities

    public class MulticastOption
{
    //Potential Multicasting in the future
    
    public class TestMulticastOption
    {
        private static IPAddress s_mcastAddress;
        private static int s_mcastPort;
        private static Socket s_mcastSocket;
        private static MulticastOption s_mcastOption;

        private static void MulticastOptionProperties()
        {
            Console.WriteLine("Current multicast group is: " + s_mcastOption.Group);
            Console.WriteLine("Current multicast local address is: " + s_mcastOption.LocalAddress);
        }

        private static void StartMulticast()
        {
            try
            {
                s_mcastSocket = new Socket(AddressFamily.InterNetwork,
                                         SocketType.Dgram,
                                         ProtocolType.Udp);

                Console.Write("Enter the local IP address: ");

                IPAddress localIPAddr = IPAddress.Parse(Console.ReadLine());

                //IPAddress localIP = IPAddress.Any;
                EndPoint localEP = (EndPoint)new IPEndPoint(localIPAddr, s_mcastPort);

                s_mcastSocket.Bind(localEP);


                // Define a MulticastOption object specifying the multicast group
                // address and the local IPAddress.
                // The multicast group address is the same as the address used by the server.
                s_mcastOption = new MulticastOption(s_mcastAddress, localIPAddr);

                s_mcastSocket.SetSocketOption(SocketOptionLevel.IP,
                                            SocketOptionName.AddMembership,
                                            s_mcastOption);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveBroadcastMessages()
        {
            bool done = false;
            byte[] bytes = new byte[100];
            IPEndPoint groupEP = new(s_mcastAddress, s_mcastPort);
            EndPoint remoteEP = (EndPoint)new IPEndPoint(IPAddress.Any, 0);

            try
            {
                while (!done)
                {
                    Console.WriteLine("Waiting for multicast packets.......");
                    Console.WriteLine("Enter ^C to terminate.");

                    s_mcastSocket.ReceiveFrom(bytes, ref remoteEP);

                    Console.WriteLine("Received broadcast from {0} :\n {1}\n",
                      groupEP.ToString(),
                      Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                }

                s_mcastSocket.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Main(string[] args)
        {
            // Initialize the multicast address group and multicast port.
            // Both address and port are selected from the allowed sets as
            // defined in the related RFC documents. These are the same
            // as the values used by the sender.
            s_mcastAddress = IPAddress.Parse("224.168.100.2");
            s_mcastPort = 11000;

            // Start a multicast group.
            StartMulticast();

            // Display MulticastOption properties.
            MulticastOptionProperties();

            // Receive broadcast messages.
            ReceiveBroadcastMessages();
        }
    }
}