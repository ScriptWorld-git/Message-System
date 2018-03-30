using System;
namespace MessageSystem
{
    public static class ms
    {
        private static MsgSystem sys = new MsgSystem();

        public static void saveMode(bool mode)
        {
            sys.saveMode(mode);
        }

        public static void addGroup(int ident, string name)
        {
            sys.addGroup(ident, name);
        }

        public static void log(object message)
        {
            sys.log(message);
        }

        public static void log(object message, int group)
        {
            sys.log(message, group);
        }
    }
}
