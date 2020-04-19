using System;
using System.Net.Http;

namespace LoadTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var http = new HttpClient();
            var uri = "https://pcf-demos-web-v1.apps.pcfone.io/scale/scale?id={0}";

            for (int index = 1; index < 7500; index++)
            {
                Console.WriteLine(uri, index);

                http.GetAsync(uri);
            }

            Console.WriteLine("DONE");
            Console.ReadLine();
        }
    }
}
