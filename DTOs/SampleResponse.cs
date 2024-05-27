using System.Xml.Serialization;
using MassTransit;

namespace SoapDemo.DTOs;

public enum ResponseType
{
    Xml,
    Json
}

public class SampleXmlResponse
{
    [XmlElement("Id")]
    public Guid Id { get; set; } = NewId.NextGuid();

    [XmlElement("Type")]
    public ResponseType Type { get; set; } = ResponseType.Xml;
}

public class SampleJsonResponse
{
    public Guid Id { get; set; } = NewId.NextGuid();
    public ResponseType Type { get; set; } = ResponseType.Json;
}