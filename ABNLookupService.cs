using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;

namespace abn_service_client
{
    public class ABNLookupService
    {
        private static readonly HttpClient client = new HttpClient();



        public ABNLookupService()
        {

        }

       

        public async Task<ABRPayloadSearchResults> SearchByABNv201408(string abn,string authenticationGuid)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var queryUrl = $"http://abr.business.gov.au/abrxmlsearch/AbrXmlSearch.asmx/SearchByABNv201408?searchString={abn}&includeHistoricalDetails=Y&authenticationGuid={authenticationGuid}";

            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);


            var response = await client.SendAsync(request);


            var contents = await response.Content.ReadAsStreamAsync();

            XmlSerializer serializer = new XmlSerializer(typeof(ABRPayloadSearchResults));

            var result = (ABRPayloadSearchResults)serializer.Deserialize(contents);

            return result;

        }
    }
}
