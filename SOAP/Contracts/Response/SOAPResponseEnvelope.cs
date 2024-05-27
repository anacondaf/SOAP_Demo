using System.Xml.Serialization;

namespace SoapDemo.SOAP.Contracts.Response;

[XmlRoot("Envelope", Namespace = SoapConstants.SOAP1_1Namespace)]
public partial class SOAPResponseEnvelope<T> where T : SOAPResponseBody
{
    [XmlElement("Body")]
    public T? Body { get; set; }

    public SOAPResponseEnvelope()
    {
        Body = Activator.CreateInstance<T>();
    }
}