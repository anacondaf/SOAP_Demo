using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SoapDemo.SOAP.Contracts.Request;

// [XmlRoot(Namespace = SOAPRequestBody.DefaultNamespace)]
public partial class SOAPRequestBody : IXmlSerializable
{
    public virtual string DefaultNamespacePrefix { get; } = "ser";
    public virtual string DefaultNamespace { get; } = "http://example.com/service/";

    public XmlSchema? GetSchema()
    {
        return null;
    }

    public void ReadXml(XmlReader reader)
    {
        // TODO: Research about this method
    }

    public void WriteXml(XmlWriter writer)
    {
        // writer.WriteStartElement(DefaultNamespacePrefix, "SOAPRequestBody", DefaultNamespace);
        // writer.WriteEndElement();
    }
}