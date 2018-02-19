namespace abn_service_client {
    public class ABRSearchByAbnRequest {
        public string AuthenticationGuid { get; private set; }
        public string ABN { get; private set; }

        public ABRSearchByAbnRequest (string abn, string authenticationGuid) {
            AuthenticationGuid = authenticationGuid;
            ABN = abn;
        }

    }
    public class RequestStateFilter {
        public string NSW { get; private set; }
        public string SA { get; private set; }
        public string ACT { get; private set; }
        public string VIC { get; private set; }
        public string WA { get; private set; }
        public string NT { get; private set; }
        public string QLD { get; private set; }
        public string TAS { get; private set; }

        public RequestStateFilter (string nsw = "Y", string sa = "Y", string act = "Y", string vic = "Y", string wa = "Y", string nt = "Y", string qld = "Y", string tas = "Y") {
            NSW = nsw;
            SA = sa;
            ACT = act;
            VIC = vic;
            WA = wa;
            NT = nt;
            QLD = qld;
            TAS = tas;
        }
    }
    public class ABRSearchByNameRequest {

        public string Name { get; private set; }
        public string Postcode { get; private set; }
        public string LegalName { get; private set; }
        public string TradingName { get; private set; }
        public string BusinessName { get; private set; }
        public string ActiveABNsOnly { get; private set; }
        public RequestStateFilter StateFilter { get; private set; }

        public string AuthenticationGuid { get; private set; }
        public string SearchWidth { get; private set; }
        public string MinimumScore { get; private set; }
        public string MaxSearchResults { get; private set; }

        public ABRSearchByNameRequest (string name, string authenticationGuid, string postcode = "ALL", string legalName = "Y", string tradingName = "Y", string businessName = "Y", string activeABNsOnly = "Y", string searchWidth = "typical", string minimumScore = "0", string maxSearchResults = "200", RequestStateFilter stateFilter = null) {
            Name = name;
            AuthenticationGuid = authenticationGuid;

            Postcode = postcode;
            LegalName = legalName;
            TradingName = tradingName;
            BusinessName = businessName;
            ActiveABNsOnly = activeABNsOnly;
            StateFilter = stateFilter??new RequestStateFilter ();

            SearchWidth = searchWidth;
            MinimumScore = minimumScore;
            MaxSearchResults = maxSearchResults;
        }

    }
}