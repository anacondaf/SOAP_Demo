using System.Xml.Serialization;

namespace SoapDemo.SOAP.Contracts.Request;

[XmlRoot("Envelope", Namespace = SoapConstants.SOAP1_1Namespace)]
public partial class SOAPRequestEnvelope<T>
    where T : SOAPRequestBody
{
    public SOAPRequestHeader? Header { get; set; }
    public T Body { get; set; } = default!;
}