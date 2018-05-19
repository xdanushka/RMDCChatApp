using MaterialSkin.Controls;
using MessageCareer;
using RMDCChatClient.Models;
using RMDCChatClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Message = RMDCChatClient.Models.Message;

namespace RMDCChatClient
{

    public partial class ChatRoomForm : MaterialForm
    {
        private TcpClient _clientSocket;
        private readonly List<Message> _messages = new List<Message>();
        private readonly User _user;
        private Dictionary<int, string> _allUsers = new Dictionary<int, string>();
        private readonly DbHelper _dbHelper = new DbHelper();
        private readonly BinaryFormatter _bformatter = new BinaryFormatter();
        private NetworkStream _serverStream;
        private bool _listen = true;

        public ChatRoomForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void ChatNow_Load(object sender, EventArgs e)
        {
            _clientSocket = new TcpClient();
            _clientSocket.Connect("127.0.0.1", 8888);
            _serverStream = _clientSocket.GetStream();

            _allUsers = _dbHelper.GetAllUsers();

            var msg = new ChatMessage
            {
                Users = new List<int>() { _user.Id }
            };

            SendMessage(msg);
            var inmessage = RceiveMessage();

            foreach (var v in inmessage.Users)
            {
                lst_online.Items.Add(new ListViewItem(_allUsers[v]));
            }

            var msgs = _dbHelper.GetMessages(_user.Id);
            foreach (var m in msgs)
            {
                lst_chat.Items.Add(m.message + " (" + m.timestamp + ")");
            }

            lbl_user.Text = _user.userName;

            backgroundWorker1.RunWorkerAsync();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tbox_msg.Text.Equals("")) { return; }

            if (lst_online.SelectedItems.Count == 0)
            {
                MessageBox.Show(Resources.ResourceManager.GetString("send_no_user_selected"));
                return;
            }
            var toList = new List<int>();
            foreach (ListViewItem i in lst_online.SelectedItems)
            {
                toList.Add(_allUsers.FirstOrDefault(x => x.Value.Equals(i.Text)).Key);
            }
            toList.Add(_user.Id);
            var msg = new ChatMessage
            {
                Users = toList,
                Message = tbox_msg.Text
            };

            SendMessage(msg);

            toList.Remove(_user.Id);
            var m = new Message
            {
                message = tbox_msg.Text,
                fromUser = _user.Id,
                toUser = toList,
                timestamp = DateTime.Now

            };
            _messages.Add(m);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_listen)
            {
                try
                {
                    var inmessage = RceiveMessage();
                    if (inmessage.Message == null)
                    {
                        lst_online.BeginInvoke(new MethodInvoker(delegate
                        {
                            foreach (int i in inmessage.Users)
                            {
                                if (!_allUsers.ContainsKey(i))
                                {
                                    _allUsers.Add(i, _dbHelper.GetUserName(i));
                                }
                                lst_online.Items.Add(_allUsers[i]);
                            }
                        }));
                    }
                    else if (inmessage.Message.Equals("sent"))
                    {
                        lst_chat.BeginInvoke(new MethodInvoker(delegate
                        {
                            tbox_msg.BeginInvoke(new MethodInvoker(delegate
                            {
                                lst_chat.Items.Add("You: " + tbox_msg.Text + " (" + inmessage.Message + ")");
                                tbox_msg.Text = "";
                            }));

                        }));
                    }
                    else if (inmessage.Message.Equals("&off&"))
                    {
                        lst_online.BeginInvoke(new MethodInvoker(delegate
                        {
                            for (var i = 0; i < lst_online.Items.Count; i++)
                            {
                                if (!lst_online.Items[i].Text.Equals(_allUsers[inmessage.Users[0]])) continue;
                                lst_online.Items.RemoveAt(i);
                                MessageBox.Show(_allUsers[inmessage.Users[0]] + Resources.user_logoff);
                                lst_online.SelectedItems.Clear();
                            }
                        }));
                    }
                    else
                    {
                        lst_chat.BeginInvoke(new MethodInvoker(delegate
                        {
                            lst_chat.Items.Add(_allUsers[inmessage.Users[0]] + ": " + inmessage.Message);
                        }));
                    }
                }
                catch (Exception)
                {
                    // MessageBox.Show(user.userName + " " + ee.Message);
                }
            }
        }

        private void ChatRoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbHelper.SaveMessages(_messages);
            _messages.Clear();
            _listen = false;

            try
            {
                ChatMessage msg = new ChatMessage
                {
                    Users = new List<int> { _user.Id },
                    Message = "&off&"

                };
                SendMessage(msg);
            }
            catch (Exception)
            {
                // MessageBox.Show(ee.Message);
            }
            finally
            {

                Application.Exit();
            }
        }

        private void SendMessage(ChatMessage message)
        {
            _bformatter.Serialize(_serverStream, message);
            _serverStream.Flush();
        }

        private ChatMessage RceiveMessage()
        {
            var msg = (ChatMessage)_bformatter.Deserialize(_serverStream);
            _serverStream.Flush();
            return msg;
        }
    }
}
