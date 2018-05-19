using MessageCareer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace RMDCChatServer
{
    class Program
    {

        public static Dictionary<int, TcpClient> Clients = new Dictionary<int, TcpClient>();
        public static void Main()
        {
           // var program = new Program();
            try
            {

                var ipAddress = IPAddress.Parse("127.0.0.1");
                var server = new TcpListener(ipAddress, 8888);

                Console.WriteLine("The server is running at port 8001...");
                Console.WriteLine("The local End point is  :" + server.LocalEndpoint);
                server.Start();

                while (true)
                {

                    Console.WriteLine(Clients.Keys.Count + " Users are Online");
                    Console.WriteLine("Waiting for a connection.....");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine(client);
                    //process each client in different thread
                    var ctThread = new Thread(() => DoChat(client));
                    ctThread.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }
        private static void DoChat(TcpClient client)
        {

            while (true)
            {
                try
                {

                    var networkStream = client.GetStream();
                    var bformatter = new BinaryFormatter();
                    var message = (ChatMessage)bformatter.Deserialize(networkStream);

                    //client connected
                    if (message.Message == null)
                    {
                        var msg = new ChatMessage { Users = new List<int>() { message.Users[0] } };

                        foreach (var c in Clients)
                        {
                            if (c.Key == message.Users[0]) continue;
                            var stream = c.Value.GetStream();
                            bformatter.Serialize(stream, msg);
                            stream.Flush();
                        }

                        msg.Users = Clients.Keys.ToList();
                        bformatter.Serialize(networkStream, msg);
                        networkStream.Flush();
                        Clients.Add(message.Users[0], client);


                    }

                    //client disconnected
                    else if (message.Message.Equals("&off&"))
                    {
                        Clients.Remove(message.Users[0]);

                        foreach (var c in Clients)
                        {
                            var stream = c.Value.GetStream();
                            bformatter.Serialize(stream, message);
                            stream.Flush();
                        }
                        client.Close();
                        break;

                    }
                    //client chat with one or more clients
                    else
                    {
                        var sendUser = message.Users[message.Users.Count - 1];
                        message.Users.RemoveAt(message.Users.Count - 1);
                        foreach (var c in message.Users)
                        {

                            var msg = new ChatMessage
                            {
                                Users = new List<int>() { sendUser },
                                Message = message.Message
                            };
                            networkStream = Clients[c].GetStream();
                            bformatter.Serialize(networkStream, msg);

                        }
                        var msgforOwner = new ChatMessage
                        {
                            Users = Clients.Keys.ToList(),
                            Message = "sent"
                        };
                        bformatter.Serialize(client.GetStream(), msgforOwner);
                        networkStream.Flush();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    break;
                }
            }
        }
    }
}
