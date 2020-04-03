using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
namespace MuleStash
{
    class Mulestash
    {
        public List<Mule> mules = new List<Mule>();

        private void OnStartup()
        {
            //mules.Add(RegisterMule());


        }
        public Mulestash()
        {
            this.OnStartup();
            while (true)
            {
            Console.Write(">");
            string input = Console.ReadLine();
                if (input=="mulecount")
                {
                    Console.WriteLine();
                }
                else if(input=="help")
                {
                    Console.WriteLine("current commands help");
                }

                else
                {
                    Console.WriteLine("No command found, type help for commands..");
                }
                    
            }

        }

        public Mule RegisterMule()
        {
            Mule newmule = new Mule(Utitily.RandomString(6) + "@" + Utitily.RandomString(3) + "." + Utitily.RandomString(2), Utitily.RandomString(2));

            string url = "https://realmofthemadgodhrd.appspot.com/account/register?guid=DDDDDDDD30A5B289EA856859A8&newGUID=" + newmule.guid + "&newPassword=" + newmule.password+ "&isAgeVerified=1";
            string response = Utitily.WebGetRequest(url);

            if (response.StartsWith("<Success>"))
            {
                newmule.valid = true;
                return newmule;

            } else
            {
            Console.WriteLine(response);
                newmule.valid = false;
                return newmule;
            }
        }
    }
}