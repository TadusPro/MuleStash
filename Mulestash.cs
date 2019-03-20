using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MuleStash
{
    class Mulestash
    {
        public Mulestash()
        {

        }

        public Mule RegisterMule()
        {
            Random random = new Random();
            string RandomStringlower(int length)
            {
                const string chars = "abcdefghijklmnopqrstuvwxyz";
                return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            string Randomint(int length)
            {
                const string chars = "0123456789";
                return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            }

            Mule newmule = new Mule()
            {
                name = RandomStringlower(9),
                guid = RandomStringlower(12) + "@mule.zozk.org",
                password = RandomStringlower(8)+ Randomint(8) + "WEFHO"
            };

            string url = "http://realmofthemadgodhrd.appspot.com/account/register?newGUID=" + newmule.guid + "&newPassword=" + newmule.password + "&name=" + newmule.name;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var responsestream = (HttpWebResponse)request.GetResponse();
            string response = new StreamReader(responsestream.GetResponseStream()).ReadToEnd();

            Console.WriteLine(newmule.ToString());
            Console.WriteLine(response);


            return newmule;
        }
    }
}