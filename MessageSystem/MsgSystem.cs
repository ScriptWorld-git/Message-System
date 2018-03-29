using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageSystem
{
    public class MsgSystem
    {
        private List<Message> messages = new List<Message>();
        private Dictionary<int, string> groups = new Dictionary<int, string>();


        public MsgSystem()
        {
            groups.Add(-1, "MSG");
        }

        public void addGroup(int ident, string name)
        {
            string temp;
            bool found = groups.TryGetValue(ident, out temp);

            if (!found)
            {
                groups.Add(ident, name);
            }
        }

        public void log(object message)
        {
            messages.Add(new Message(message, -1));
        }

        public void log(object message, int group)
        {
            messages.Add(new Message(message, group));
        }
    }
}
