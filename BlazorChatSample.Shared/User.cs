using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChatSample.Shared
{
    /// <summary>
    /// User class
    /// </summary>
    public class User
    {
        public string Username { get; set; }
        public string ConnectionId { get; set; }

        public User(string username, string connectionId)
        {
            Username = username;
            ConnectionId = connectionId;
        }

        public override string ToString()
        {
            return $"{Username} ({ConnectionId})";
        }

        public override bool Equals(object obj)
        {
            if (obj is User user)
                return user.ConnectionId == ConnectionId;
            return false;
        }

        public override int GetHashCode()
        {
            return ConnectionId.GetHashCode();
        }

        public bool ContainsKey(string connectionId)
        {
            return ConnectionId == connectionId;
        }
    }
}
