using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageSystem
{
    internal class Message : IComparable<Message>
    {
        private int group;
        private DateTime timeStamp;
        private object message;

        public Message(object message, int group = -1)
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
            return getTimeStampString() + " | "
        }

        public int CompareTo(Message other)
        {
            return DateTime.Compare(this.timeStamp, other.timeStamp);
        }
    }
}
