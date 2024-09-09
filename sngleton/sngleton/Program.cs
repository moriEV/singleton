using sngleton;
using static System.Net.WebRequestMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        Servers single = Servers.Instance;
        single.AddServer("http://yandex.ru");
        single.GetHTTP();
        single.GetHTTPS();


    }
}