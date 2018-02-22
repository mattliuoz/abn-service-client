using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;

namespace abn_service_client {
    public class ABNLookupService {
        private static readonly HttpClient client = new HttpClient () { BaseAddress = new Uri ("http://abr.business.gov.au") };

        public ABNLookupService () {

        }

        public async Task<SearchByNameResults> ABRSearchByNameAdvancedSimpleProtocol2017 (ABRSearchByNameRequest lookupRequest) {
            var queryUrl = $"/abrxmlsearch/AbrXmlSearch.asmx/ABRSearchByNameAdvancedSimpleProtocol2017{lookupRequest.ToQueryString()}";
            client.DefaultRequestHeaders.Accept.Clear ();

            using (var response = await client.GetAsync (queryUrl).ConfigureAwait (false)) {
                var body = await response.Content.ReadAsStreamAsync ();
                if (response.IsSuccessStatusCode) {
                    var serializer = new XmlSerializer (typeof (SearchByNameResults));
                    var result = (SearchByNameResults) serializer.Deserialize (body);
                    return result;
                } else {
                    var contents = await response.Content.ReadAsStringAsync ();
                    Console.Write ($"oh err. {contents}");
                    //do something ehre
                }
                return new SearchByNameResults ();
            }
        }

        public async Task<SearchByABNResults> SearchByABNv201408 (ABRSearchByAbnRequest lookupRequest) {
            try {
                client.DefaultRequestHeaders.Accept.Clear ();
                var result = new SearchByABNResults ();
                var queryUrl = $"/abrxmlsearch/AbrXmlSearch.asmx/SearchByABNv201408{lookupRequest.ToQueryString()}";
                Console.WriteLine (queryUrl);
                using (var response = await client.GetAsync (queryUrl).ConfigureAwait (false)) {
                    if (response.IsSuccessStatusCode) {
                        var contents = await response.Content.ReadAsStreamAsync ();

                        var serializer = new XmlSerializer (typeof (SearchByABNResults));

                        result = (SearchByABNResults) serializer.Deserialize (contents);
                    } else {
                        var contents = await response.Content.ReadAsStringAsync ();
                        Console.Write ($"oh err. {contents}");
                        //do something ehre
                    }
                    return result;
                }
            } catch (Exception e) {
                return new SearchByABNResults ();
            }

        }
    }
}