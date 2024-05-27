using SoapDemo.DTOs;
using SoapDemo.SOAP.Contracts.Response;
using System.Xml;
using System.Xml.Serialization;

namespace SoapDemo.Model.SOAPRequestBodies;

public class GetSampleXmlResponseBody : SOAPResponseBody
{
    [XmlElement("GetSampleXmlResponse")]
    public GetSampleXmlResponse? GetSampleXmlResponse { get; set; }

    public override string DefaultNamespace => "http://example.com/service1/";
    public override string DefaultNamespacePrefix => "ser1";

    // public override void WriteXml(XmlWriter writer)
    // {
    //     writer.WriteStartElement(DefaultNamespacePrefix, "GetSampleXmlResponse", DefaultNamespace);

    //     foreach (var response in GetSampleXmlResponse.SampleXmlResponses!)
    //     {
    //         writer.WriteStartElement(DefaultNamespacePrefix, "SampleXmlResponse", DefaultNamespace);
    //         writer.WriteElementString("Id", response.Id.ToString());
    //         writer.WriteElementString("Type", response.Type.ToString());
    //         writer.WriteEndElement();
    //     }

    //     writer.WriteEndElement();
    // }
}