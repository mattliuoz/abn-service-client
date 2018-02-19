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
            Console.WriteLine("Searching ABR");


            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var abnAuthenticationGuid=Configuration["ABNAuthenticationGuid"];

            var abnLookupService = new ABNLookupService();
            var abn = args[0];
            var searchByAbnRequest = new ABRSearchByAbnRequest(abn,abnAuthenticationGuid);

            var searchByAbnResult = abnLookupService.SearchByABNv201408(searchByAbnRequest).Result;//WILL IOC later
            Console.WriteLine("Search by ABN: "+ searchByAbnResult.Response.BusinessEntity201408.OtherTradingName.OrganisationName);

            var searchByNameRequest = new ABRSearchByNameRequest("Matt Liu",abnAuthenticationGuid);
            var searchByNameResult = abnLookupService.ABRSearchByNameAdvancedSimpleProtocol2017(searchByNameRequest).Result;
            Console.WriteLine("Search by Name result count: "+searchByNameResult.Response.SearchResultsList.SearchResultsRecord.Count);

            Console.WriteLine("Press a key...");
            Console.ReadKey();
            
        }
    }
}