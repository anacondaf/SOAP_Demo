using System.Xml.Serialization;

namespace SoapDemo.DTOs;

public class GetSampleXmlResponse
{
    [XmlArray("SampleXmlResponses")]
    [XmlArrayItem("SampleXmlResponse")]
    public List<SampleXmlResponse> SampleXmlResponses { get; set; } = default!;

    public GetSampleXmlResponse()
    {
    }
}