using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace abn_service_client {

    class Program {
        public static IConfiguration Configuration { get; set; }

        static void Main (string[] args) {
            Console.WriteLine ("Searching ABR");

            var builder = new ConfigurationBuilder ()
                .SetBasePath (Directory.GetCurrentDirectory ())
                .AddJsonFile ("appsettings.json");

            Configuration = builder.Build ();

            var abnAuthenticationGuid = Configuration["ABNAuthenticationGuid"];

            var abnLookupService = new ABNLookupService ();
            var abn = args[0];
            var searchByAbnRequest = new ABRSearchByAbnRequest (abn, abnAuthenticationGuid);

            var searchByAbnResult = abnLookupService.SearchByABNv201408 (searchByAbnRequest).Result; //WILL IOC later
            if (searchByAbnResult.Response != null) {
                if (searchByAbnResult.Response.Exception != null) {
                    Console.Write ($"Search by name got error:{searchByAbnResult.Response.Exception.ExceptionDescription}");
                } else {
                    Console.WriteLine ("Search by ABN: " + searchByAbnResult.Response.BusinessEntity201408.OtherTradingName.OrganisationName);
                }
            }else{
                Console.WriteLine("Something's wrong");
            }

            //var searchByNameRequest = new ABRSearchByNameRequest("Matt Liu",abnAuthenticationGuid,businessName:"wtf");
            var searchByNameRequest = new ABRSearchByNameRequest ("Matt Liu",abnAuthenticationGuid);
            var searchByNameResult = abnLookupService.ABRSearchByNameAdvancedSimpleProtocol2017 (searchByNameRequest).Result;
            if (searchByNameResult.Response.Exception != null) {
                Console.Write ($"Search by name got error:{searchByNameResult.Response.Exception.ExceptionDescription}");
            } else {
                Console.WriteLine ("Search by Name result count: " + searchByNameResult.Response.SearchResultsList.SearchResultsRecord.Count);
            }

            Console.WriteLine ("Press a key...");
            Console.ReadKey ();

        }
    }
}