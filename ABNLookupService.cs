using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;

namespace abn_service_client {
    public class ABNLookupService {
        private static readonly HttpClient client = new HttpClient ();

        public ABNLookupService () {

        }

        public async Task<SearchByNameResults> ABRSearchByNameAdvancedSimpleProtocol2017 (ABRSearchByNameRequest lookupRequest)
        {
            var queryUrl = BuildABRSearchByNameAdvancedSimpleProtocol2017Url(lookupRequest);

            client.DefaultRequestHeaders.Accept.Clear();
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);

            var response = await client.SendAsync(request);

            var contents = await response.Content.ReadAsStreamAsync();

            XmlSerializer serializer = new XmlSerializer(typeof(SearchByNameResults));

            var result = (SearchByNameResults)serializer.Deserialize(contents);

            return result;
        }

        private string BuildABRSearchByNameAdvancedSimpleProtocol2017Url(ABRSearchByNameRequest lookupRequest)
        {
            var sbQueryUrl = new StringBuilder();
            sbQueryUrl.Append("http://abr.business.gov.au/abrxmlsearch/AbrXmlSearch.asmx/ABRSearchByNameAdvancedSimpleProtocol2017?");
            sbQueryUrl.Append($"name={lookupRequest.Name}");
            sbQueryUrl.Append($"&postcode={lookupRequest.Postcode}");
            sbQueryUrl.Append($"&legalName={lookupRequest.LegalName}");
            sbQueryUrl.Append($"&tradingName={lookupRequest.TradingName}");
            sbQueryUrl.Append($"&businessName={lookupRequest.BusinessName}");
            sbQueryUrl.Append($"&activeABNsOnly={lookupRequest.ActiveABNsOnly}");
            sbQueryUrl.Append($"&NSW={lookupRequest.StateFilter.NSW}");
            sbQueryUrl.Append($"&SA={lookupRequest.StateFilter.SA}");
            sbQueryUrl.Append($"&ACT={lookupRequest.StateFilter.ACT}");
            sbQueryUrl.Append($"&VIC={lookupRequest.StateFilter.VIC}");
            sbQueryUrl.Append($"&WA={lookupRequest.StateFilter.WA}");
            sbQueryUrl.Append($"&NT={lookupRequest.StateFilter.NT}");
            sbQueryUrl.Append($"&QLD={lookupRequest.StateFilter.QLD}");
            sbQueryUrl.Append($"&TAS={lookupRequest.StateFilter.TAS}");
            sbQueryUrl.Append($"&authenticationGuid={lookupRequest.AuthenticationGuid}");
            sbQueryUrl.Append($"&searchWidth={lookupRequest.SearchWidth}");
            sbQueryUrl.Append($"&minimumScore={lookupRequest.MinimumScore}");
            sbQueryUrl.Append($"&maxSearchResults={lookupRequest.MaxSearchResults}");
            return sbQueryUrl.ToString();
        }

        public async Task<SearchByABNResults> SearchByABNv201408 (ABRSearchByAbnRequest lookupRequest) {
            client.DefaultRequestHeaders.Accept.Clear ();

            var queryUrl = $"http://abr.business.gov.au/abrxmlsearch/AbrXmlSearch.asmx/SearchByABNv201408?searchString={lookupRequest.ABN}&includeHistoricalDetails=Y&authenticationGuid={lookupRequest.AuthenticationGuid}";

            var request = new HttpRequestMessage (HttpMethod.Get, queryUrl);

            var response = await client.SendAsync (request);

            var contents = await response.Content.ReadAsStreamAsync ();

            XmlSerializer serializer = new XmlSerializer (typeof (SearchByABNResults));

            var result = (SearchByABNResults) serializer.Deserialize (contents);

            return result;

        }
    }
}