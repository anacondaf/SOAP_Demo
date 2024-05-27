using System.Xml;
using System.Xml.Serialization;

namespace SoapDemo.SOAP.Contracts.Response;

public partial class SOAPResponseBody
// : IXmlSerializable
{
    public SOAPResponseBody()
    {
    }

    [XmlAttribute("DefaultNamespacePrefix")]
    public virtual string DefaultNamespacePrefix { get; } = "ser";

    [XmlAttribute("DefaultNamespace")]
    public virtual string DefaultNamespace { get; } = "http://example.com/service/";

    //xmlns:ser=""http://example.com/service/"

    // public XmlSchema? GetSchema()
    // {
    //     return null;
    // }

    // public void ReadXml(XmlReader reader)
    // {
    //     // reader.ReadStartElement("SOAPResponseBody", DefaultNamespace);
    //     // reader.ReadEndElement();
    // }

    // public virtual void WriteXml(XmlWriter writer)
    // {
    //     writer.WriteStartElement(DefaultNamespacePrefix, "SOAPRequestBody", DefaultNamespace);
    //     writer.WriteEndElement();
    // }
}