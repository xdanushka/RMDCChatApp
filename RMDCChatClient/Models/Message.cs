using System;
using System.Collections.Generic;

namespace RMDCChatClient.Models
{
    class Message
    {
        public int Id { get; set; }
        public string message { get; set; }
        public int fromUser { get; set; }
        public List<int> toUser { get; set; }
        public DateTime timestamp { get; set; }
    }
}
