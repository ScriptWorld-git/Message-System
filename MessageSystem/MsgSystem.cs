using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageSystem
{
    public class MsgSystem
    {
        private const int groupLength = 4;
        private const string defString = "MSG";

        private bool save = false;

        private List<Message> messages = new List<Message>();
        private Dictionary<int, string> groups = new Dictionary<int, string>();

        public MsgSystem()
        {
            string def = defString;

            while (def.Length < groupLength)
            {
                def += " ";
            }

            groups.Add(-1, def);
        }

        public void saveMode(bool mode)
        {
            this.save = mode;
        }

        public void addGroup(int ident, string name)
        {
            string temp;
            bool found = groups.TryGetValue(ident, out temp);

            if (!found)
            {

                if (name.Length > groupLength)
                    name = name.Substring(0, groupLength);
                else if (name.Length < groupLength)
                {
                    while (name.Length < groupLength)
                    {
                        name += " ";
                    }
                }

                groups.Add(ident, name);
            }
        }

        public void log(object message)
        {
            log(message, -1);
        }

        public void log(object message, int group)
        {
            Message m = new Message(message, getGroupString(group));
            Console.WriteLine(m.ToString());

            if (save)
                messages.Add(m);
        }

        private string getGroupString(int key)
        {
            string temp;
            bool found = groups.TryGetValue(key, out temp);

            if (!found)
                temp = groups[-1];

            return temp;
        }
    }
}
