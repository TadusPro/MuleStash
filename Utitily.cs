using System;
using System.IO;
using System.Linq;
using System.Net;
using Leaf.xNet;
namespace MuleStash
{
    class Utitily
    {
        public static string WebGetRequest(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var responsestream = (HttpWebResponse)request.GetResponse();
            return new StreamReader(responsestream.GetResponseStream()).ReadToEnd();
        }
        public static string WebPostRequest(string url, string data)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var responsestream = (HttpWebResponse)request.GetResponse();
            return new StreamReader(responsestream.GetResponseStream()).ReadToEnd();
        }
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string Randomint(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
