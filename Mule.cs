using System;

namespace MuleStash
{
    class Mule
    {
        public string guid;
        public string password;
        public string name;
        public Char[] ch;
        public Chest[] chest;
        public DateTime lastUpdate;
        public bool valid;

        public Mule(string guid, string password)
        {
            this.guid = guid;
            this.password = password;
        }

        public override string ToString()
        {
            return "name: " + name + " email: " + guid + " password: " + password;
        }

        public string ToMuledumpString()
        {
            return "\"" + guid + "\":\"" + password + "\",";
        }

    }
}