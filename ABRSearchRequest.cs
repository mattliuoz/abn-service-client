namespace abn_service_client
{
    public class ABRSearchByAbnRequest{
        public string AuthenticationGuid { get; private set; }
        public string ABN {get; private set;}

        public ABRSearchByAbnRequest(string abn, string authenticationGuid)
        {
            AuthenticationGuid=authenticationGuid;
            ABN = abn;
        }
    }
}