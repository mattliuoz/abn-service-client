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

        // public async Task<ABRPayloadSearchResults> ABRSearchByNameAdvancedSimpleProtocol2017(ABRSearchByNameAdvancedSimpleProtocol2017Request lookupRequest)
        // {
        //     var queryUrl =@"/AbrXmlSearch.asmx/ABRSearchByNameAdvancedSimpleProtocol2017?
        //     name=string
        //     &postcode=string
        //     &legalName=string
        //     &tradingName=string
        //     &businessName=string
        //     &activeABNsOnly=string
        //     &NSW=string
        //     &SA=string
        //     &ACT=string
        //     &VIC=string
        //     &WA=string
        //     &NT=string
        //     &QLD=string
        //     &TAS=string
        //     &authenticationGuid=string
        //     &searchWidth=string
        //     &minimumScore=string
        //     &maxSearchResults=string";

        // }
       

        public async Task<ABRPayloadSearchResults> SearchByABNv201408(ABRSearchByAbnRequest lookupRequest)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var queryUrl = $"http://abr.business.gov.au/abrxmlsearch/AbrXmlSearch.asmx/SearchByABNv201408?searchString={lookupRequest.ABN}&includeHistoricalDetails=Y&authenticationGuid={lookupRequest.AuthenticationGuid}";

            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);


            var response = await client.SendAsync(request);


            var contents = await response.Content.ReadAsStreamAsync();

            XmlSerializer serializer = new XmlSerializer(typeof(ABRPayloadSearchResults));

            var result = (ABRPayloadSearchResults)serializer.Deserialize(contents);

            return result;

        }
    }
}
