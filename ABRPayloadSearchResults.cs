using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abn_service_client
{
   

    [XmlRoot(ElementName = "ABN", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class ABN
    {
        [XmlElement(ElementName = "identifierValue", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string IdentifierValue { get; set; }
        [XmlElement(ElementName = "isCurrentIndicator", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string IsCurrentIndicator { get; set; }
        [XmlElement(ElementName = "replacedFrom", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string ReplacedFrom { get; set; }
    }

    [XmlRoot(ElementName = "entityStatus", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class EntityStatus
    {
        [XmlElement(ElementName = "entityStatusCode", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EntityStatusCode { get; set; }
        [XmlElement(ElementName = "effectiveFrom", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EffectiveFrom { get; set; }
        [XmlElement(ElementName = "effectiveTo", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EffectiveTo { get; set; }
    }

    [XmlRoot(ElementName = "entityType", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class EntityType
    {
        [XmlElement(ElementName = "entityTypeCode", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EntityTypeCode { get; set; }
        [XmlElement(ElementName = "entityDescription", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EntityDescription { get; set; }
    }

    [XmlRoot(ElementName = "legalName", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class LegalName
    {
        [XmlElement(ElementName = "givenName", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string GivenName { get; set; }
        [XmlElement(ElementName = "otherGivenName", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string OtherGivenName { get; set; }
        [XmlElement(ElementName = "familyName", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string FamilyName { get; set; }
        [XmlElement(ElementName = "effectiveFrom", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EffectiveFrom { get; set; }
        [XmlElement(ElementName = "effectiveTo", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EffectiveTo { get; set; }
    }

    [XmlRoot(ElementName = "mainBusinessPhysicalAddress", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class MainBusinessPhysicalAddress
    {
        [XmlElement(ElementName = "stateCode", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string StateCode { get; set; }
        [XmlElement(ElementName = "postcode", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string Postcode { get; set; }
        [XmlElement(ElementName = "effectiveFrom", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EffectiveFrom { get; set; }
        [XmlElement(ElementName = "effectiveTo", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string EffectiveTo { get; set; }
    }

    [XmlRoot(ElementName = "businessEntity201408", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class BusinessEntity201408
    {
        [XmlElement(ElementName = "recordLastUpdatedDate", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string RecordLastUpdatedDate { get; set; }
        [XmlElement(ElementName = "ABN", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public ABN ABN { get; set; }
        [XmlElement(ElementName = "entityStatus", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public EntityStatus EntityStatus { get; set; }
        [XmlElement(ElementName = "ASICNumber", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string ASICNumber { get; set; }
        [XmlElement(ElementName = "entityType", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public EntityType EntityType { get; set; }
        [XmlElement(ElementName = "legalName", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public LegalName LegalName { get; set; }
        [XmlElement(ElementName = "mainBusinessPhysicalAddress", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public MainBusinessPhysicalAddress MainBusinessPhysicalAddress { get; set; }
    }

    [XmlRoot(ElementName = "response", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class Response
    {
        [XmlElement(ElementName = "usageStatement", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string UsageStatement { get; set; }
        [XmlElement(ElementName = "dateRegisterLastUpdated", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string DateRegisterLastUpdated { get; set; }
        [XmlElement(ElementName = "dateTimeRetrieved", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public string DateTimeRetrieved { get; set; }
        [XmlElement(ElementName = "businessEntity201408", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public BusinessEntity201408 BusinessEntity201408 { get; set; }
    }

    [XmlRoot(ElementName = "ABRPayloadSearchResults", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
    public class ABRPayloadSearchResults
    {
        //[XmlElement(ElementName = "request", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        //public Request Request { get; set; }
        [XmlElement(ElementName = "response", Namespace = "http://abr.business.gov.au/ABRXMLSearch/")]
        public Response Response { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
