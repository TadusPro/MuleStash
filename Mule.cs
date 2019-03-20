namespace MuleStash
{
    class Mule
    {
        public string guid;
        public string password;
        public string name;
        public Char[] ch;
        public Chest[] chest;

        public override string ToString()
        {
            return "name: " + name + " email: " + guid + " password: " + password;
        }
    }
}