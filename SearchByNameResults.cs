using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace abn_service_client
{
	[XmlRoot(ElementName="nameType", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class NameType {
		[XmlElement(ElementName="tradingName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string TradingName { get; set; }
		[XmlElement(ElementName="legalName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string LegalName { get; set; }
	}

	[XmlRoot(ElementName="stateCode", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class StateCode {
		[XmlElement(ElementName="QLD", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string QLD { get; set; }
		[XmlElement(ElementName="NT", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string NT { get; set; }
		[XmlElement(ElementName="SA", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string SA { get; set; }
		[XmlElement(ElementName="WA", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string WA { get; set; }
		[XmlElement(ElementName="VIC", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string VIC { get; set; }
		[XmlElement(ElementName="ACT", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string ACT { get; set; }
		[XmlElement(ElementName="TAS", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string TAS { get; set; }
		[XmlElement(ElementName="NSW", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string NSW { get; set; }
	}

	[XmlRoot(ElementName="filters", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class Filters {
		[XmlElement(ElementName="nameType", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public NameType NameType { get; set; }
		[XmlElement(ElementName="postcode", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string Postcode { get; set; }
		[XmlElement(ElementName="stateCode", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public StateCode StateCode { get; set; }
	}

	[XmlRoot(ElementName="nameSearchRequestAdvanced", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class NameSearchRequestAdvanced {
		[XmlElement(ElementName="authenticationGUID", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string AuthenticationGUID { get; set; }
		[XmlElement(ElementName="name", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string Name { get; set; }
		[XmlElement(ElementName="filters", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public Filters Filters { get; set; }
		[XmlElement(ElementName="searchWidth", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string SearchWidth { get; set; }
		[XmlElement(ElementName="minimumScore", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string MinimumScore { get; set; }
	}

	[XmlRoot(ElementName="request", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class Request {
		[XmlElement(ElementName="nameSearchRequestAdvanced", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public NameSearchRequestAdvanced NameSearchRequestAdvanced { get; set; }
	}

	[XmlRoot(ElementName="ABN", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class SearchByNameIdentifier {
		[XmlElement(ElementName="identifierValue", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string IdentifierValue { get; set; }
		[XmlElement(ElementName="identifierStatus", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string IdentifierStatus { get; set; }
	}

	[XmlRoot(ElementName="legalName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class LegalName {
		[XmlElement(ElementName="fullName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string FullName { get; set; }
		[XmlElement(ElementName="score", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string Score { get; set; }
		[XmlElement(ElementName="isCurrentIndicator", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string IsCurrentIndicator { get; set; }
	}

	[XmlRoot(ElementName="mainBusinessPhysicalAddress", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class MainBusinessPhysicalSimpleAddress {
		[XmlElement(ElementName="stateCode", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string StateCode { get; set; }
		[XmlElement(ElementName="postcode", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string Postcode { get; set; }
		[XmlElement(ElementName="isCurrentIndicator", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string IsCurrentIndicator { get; set; }
	}

	[XmlRoot(ElementName="searchResultsRecord", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class SearchResultsRecord {
		[XmlElement(ElementName="ABN", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public SearchByNameIdentifier ABN { get; set; }
		[XmlElement(ElementName="legalName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public LegalName LegalName { get; set; }
		[XmlElement(ElementName="mainBusinessPhysicalAddress", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public MainBusinessPhysicalSimpleAddress MainBusinessPhysicalAddress { get; set; }
		[XmlElement(ElementName="mainName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public OrganisationSimpleName MainName { get; set; }
	}

	[XmlRoot(ElementName="mainName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class OrganisationSimpleName {
		[XmlElement(ElementName="organisationName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string OrganisationName { get; set; }
		[XmlElement(ElementName="score", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string Score { get; set; }
		[XmlElement(ElementName="isCurrentIndicator", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string IsCurrentIndicator { get; set; }
	}

	[XmlRoot(ElementName="searchResultsList", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class SearchResultsList {
		[XmlElement(ElementName="numberOfRecords", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string NumberOfRecords { get; set; }
		[XmlElement(ElementName="exceedsMaximum", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string ExceedsMaximum { get; set; }
		[XmlElement(ElementName="searchResultsRecord", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public List<SearchResultsRecord> SearchResultsRecord { get; set; }
	}

	[XmlRoot(ElementName="response", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class SearchByNameResponse {
		[XmlElement(ElementName="usageStatement", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string UsageStatement { get; set; }
		[XmlElement(ElementName="dateRegisterLastUpdated", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string DateRegisterLastUpdated { get; set; }
		[XmlElement(ElementName="dateTimeRetrieved", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public string DateTimeRetrieved { get; set; }
		[XmlElement(ElementName="searchResultsList", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public SearchResultsList SearchResultsList { get; set; }
	}

	[XmlRoot(ElementName="ABRPayloadSearchResults", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class SearchByNameResults {
		[XmlElement(ElementName="response", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public SearchByNameResponse Response { get; set; }
	}
}
