using SoapDemo.Model.SOAP;
using SoapDemo.SOAP.Contracts.Request;

namespace SoapDemo.Model.SOAPRequestBodies;

public class GetSampleXmlRequestBody : SOAPRequestBody
{
    public override string DefaultNamespace => "http://example.com/service1/";
    public override string DefaultNamespacePrefix => "ser1";
    public GetWeatherForecast? GetWeatherForecast { get; set; }
}