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
            Mule newmule = new Mule()
            {
                name = Utitily.RandomString(9),
                guid = Utitily.RandomString(12) + "@mule.zozk.org",
                password = Utitily.RandomString(8)+ Utitily.Randomint(8) + "WEFHO"
            };

            string url = "https://realmofthemadgodhrd.appspot.com/account/register?newGUID=" + newmule.guid + "&newPassword=" + newmule.password + "&name=" + newmule.name + "&isAgeVerified=1";
            string response = Utitily.WebGetRequest(url);

            Console.WriteLine(newmule.ToString());
            Console.WriteLine(response);


            return newmule;
        }
    }
}