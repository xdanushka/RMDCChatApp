using RMDCChatClient.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using Exception = System.Exception;
using Message = RMDCChatClient.Models.Message;

namespace RMDCChatClient
{
    internal class DbHelper
    {
        private readonly SqlConnection _connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lotus\Desktop\Compressed\RMDCChatServer\RMDCChatApp\RMDCChatClient\bin\Debug\ChatDataBase.mdf;Integrated Security=True;Connect Timeout=30");


        private void Connect()
        {
            _connection.Open();
        }

        public User GetUser(string name, string password)
        {
            Connect();
            User u = null;
            try
            {
                var command =
                    new SqlCommand("select * from dbo.ChatUser where userName=@userName and userPassword=@password",
                        _connection);
                command.Parameters.AddWithValue("@username", name);
                command.Parameters.AddWithValue("@password", HashSha1(password));

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    u = new User
                    {
                        Id = (int) reader["Id"],
                        userName = reader["userName"].ToString(),
                        userPassword = reader["userPassword"].ToString(),
                        timestamp = Convert.ToDateTime(reader["timestamp"], CultureInfo.InvariantCulture)
                    };
                }

                reader.Dispose();
                return u;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (_connection != null) _connection.Close();
            }
            
           
            
        }

        public string GetUserName(int id)
        {
            Connect();
            try
            {
                var command = new SqlCommand("select userName from dbo.ChatUser where Id=@id", _connection);
                command.Parameters.AddWithValue("@id", id);

                var reader = command.ExecuteReader();


                reader.Read();
                var userName = reader["userName"].ToString();
                reader.Dispose();
                return userName;
            }
            finally
            {
                if (_connection != null) _connection.Close();
            }

        }

        public bool AddUser(string name, string password)
        {
            Connect();
            try
            {
                var command = new SqlCommand("select * from dbo.ChatUser where userName=@username",
                    _connection);
                command.Parameters.AddWithValue("@username", name);
                var reader = command.ExecuteReader();
                var isUser = !reader.Read();
                reader.Dispose();
                if (!isUser) return false;
                command = new SqlCommand(
                    "INSERT INTO dbo.ChatUser (userName, userPassword) values(@username, @password)",
                    _connection);
                command.Parameters.AddWithValue("@username", name);
                command.Parameters.AddWithValue("@password", HashSha1(password));
                command.ExecuteNonQuery();
                _connection.Close();
                return true;

            }
            catch (Exception)
            {
                if (_connection != null) _connection.Close();
                return false;

            }
        }


        public string HashSha1(string value)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hash)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public bool SaveMessages(List<Message> messages)
        {
            Connect();

            try
            {
                foreach (var m in messages)
                {
                    var command = new SqlCommand(
                        "INSERT INTO dbo.ChatMessage (message, fromUser, timestamp) output INSERTED.ID " +
                        "values(@message, @fromUser, @timestamp)",
                        _connection);
                    command.Parameters.AddWithValue("@message", m.message);
                    command.Parameters.AddWithValue("@fromUser", m.fromUser);
                    command.Parameters.AddWithValue("@timestamp", m.timestamp);
                    var id = (int)command.ExecuteScalar();
                    foreach (var i in m.toUser)
                    {
                        Console.WriteLine(i);
                        command = new SqlCommand(
                            "INSERT INTO dbo.MessageTo (messageId, toUser) " +
                            "values(@messageId, @toUser)",
                            _connection);
                        command.Parameters.AddWithValue("@messageId", id);
                        command.Parameters.AddWithValue("@toUser", i);
                        command.ExecuteNonQuery();
                    }
                }


                return true;
            }

            finally
            {
                if (_connection != null) _connection.Close();
            }

        }

        public Dictionary<int, string> GetAllUsers()
        {
            Connect();
            var users = new Dictionary<int, string>();
            try
            {
                var command = new SqlCommand("select Id,userName from dbo.ChatUser", _connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    users.Add((int)reader["Id"], reader["userName"].ToString());
                }

                reader.Dispose();
                return users;
            }
            finally
            {
                if (_connection != null) _connection.Close();
            }
        }

        public List<Message> GetMessages(int id)
        {
            Connect();
            var messages = new List<Message>();
            try
            {
                var command = new SqlCommand(
                    "((select Id,CONCAT('you: ',message) as msg,timeStamp from dbo.ChatMessage where fromUser=@Id)" +
                    "union" +
                    "(select ChatMessage.Id,CONCAT(ChatUser.userName,': ', ChatMessage.message) as msg,ChatMessage.timeStamp from ChatMessage join ChatUser on ChatMessage.fromUser=ChatUser.Id "+ 
                    "where ChatMessage.Id in (select distinct messageId from MessageTo where toUser=@Id)))"
                    +
                    "order by ChatMessage.timeStamp",
                    _connection);
                command.Parameters.AddWithValue("@Id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var m = new Message
                     {
                         Id = (int)reader["Id"],
                         message = reader["msg"].ToString(),
                         fromUser = id,
                         timestamp = Convert.ToDateTime(reader["timeStamp"], CultureInfo.InvariantCulture)
                     };
                    messages.Add(m);
                }
                reader.Dispose();
                return messages;
            }
            finally
            {
                if (_connection != null) _connection.Close();
            }
        }
    }
}
