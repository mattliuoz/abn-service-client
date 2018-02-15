using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace abn_service_client
{
    
    class Program
    {
        public static IConfiguration Configuration { get; set; }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var abnAuthenticationGuid=Configuration["ABNAuthenticationGuid"];

            var abnLookupService = new ABNLookupService();
            var abn = "zzzzzzzz";
            var result = abnLookupService.SearchByABNv201408(abn, abnAuthenticationGuid).Result;//WILL IOC later
            Console.WriteLine("Press a key...");
            Console.ReadKey();
            
        }
    }
}