using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sngleton
{
    internal class Servers
    {
        private static volatile Servers instance = new Servers();
        private static object syncRoot = new Object();
        public List<string> serverList {  get; set; }
        protected Servers()
        {
            serverList = new List<string> { "https://www.google.ru" };
        }
        public static Servers Instance
        {
            get
            {
                return instance;
            }
        }
        public bool AddServer(string adress)
        {
            lock (syncRoot)
            {
                if ((adress.StartsWith("http:") || adress.StartsWith("https:")) && !serverList.Contains(adress))
                {
                    serverList.Add(adress);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void GetHTTP()
        {
            foreach (var server in serverList)
            {
                if (server.StartsWith("http:"))
                {
                    Console.WriteLine(server);
                }
            }
        }
        public void GetHTTPS()
        {
            foreach (var server in serverList)
            {
                if (server.StartsWith("https:"))
                {
                    Console.WriteLine(server);
                }
            }
        }
    }
}
