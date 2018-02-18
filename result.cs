using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	

	[XmlRoot(ElementName="ABN", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class ABN {
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
	public class MainBusinessPhysicalAddress {
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
		public ABN ABN { get; set; }
		[XmlElement(ElementName="legalName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public LegalName LegalName { get; set; }
		[XmlElement(ElementName="mainBusinessPhysicalAddress", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public MainBusinessPhysicalAddress MainBusinessPhysicalAddress { get; set; }
		[XmlElement(ElementName="mainName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public MainName MainName { get; set; }
	}

	[XmlRoot(ElementName="mainName", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
	public class MainName {
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
	public class Response {
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
	public class ABRPayloadSearchResults {

		[XmlElement(ElementName="response", Namespace="http://abr.business.gov.au/ABRXMLSearch/")]
		public Response Response { get; set; }
	}

}
