using System;

namespace RMDCChatClient.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public DateTime timestamp { get; set; }
    }
}
