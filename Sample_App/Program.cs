using System;
using HelloSign;

namespace Sample_App
{
    class Program
    {
        private static Client client;

        Program()
        {
            var apiKey = "AA1001013";
            client = new Client(apiKey);
            client.SetApiHost("api.dev-hellosign.com");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
