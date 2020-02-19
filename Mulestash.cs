using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MuleStash
{
    class Mulestash
    {
        private void OnStartup()
        {

        }
        public Mulestash()
        {
            this.OnStartup();

        }

        public Mule RegisterMule()
        {
            Mule newmule = new Mule()
            {
                name = Utitily.RandomString(9),
                guid = Utitily.RandomString(12) + "@mule.zozk.org",
                password = Utitily.RandomString(8)+ Utitily.Randomint(8) + "WEFHO"
            };

            string url = "https://realmofthemadgodhrd.appspot.com/account/register?guid=DDDDDDDD30A5B289EA856859A8&newGUID=" + newmule.guid + "&newPassword=" + newmule.password + "&name=" + newmule.name + "&isAgeVerified=1";
            string response = Utitily.WebGetRequest(url);

            if (response.StartsWith("<Success>"))
            {
                return newmule;

            } else
            {
            Console.WriteLine(response);
                return new Mule();
            }
        }
    }
}