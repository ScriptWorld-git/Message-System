using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageSystem
{
    internal class Message : IComparable<Message>
    {
        private string group;
        private DateTime timeStamp;
        private object message;

        public Message(object message, string group)
        {
            this.group = group;
            this.timeStamp = DateTime.Now;
            this.message = message;
        }

        public string getTimeStampString()
        {
            return timeStamp.ToString("dd/MM-HH:mm:ss:ffff");
        }

        public override string ToString()
        {
            return getTimeStampString() +  " "  + group + " | " + message.ToString();
        }

        public int CompareTo(Message other)
        {
            return DateTime.Compare(this.timeStamp, other.timeStamp);
        }
    }
}
