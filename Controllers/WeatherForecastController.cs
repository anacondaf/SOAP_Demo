using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using SoapDemo.DTOs;
using SoapDemo.Model.SOAPRequestBodies;
using SoapDemo.SOAP.Contracts.Request;
using SoapDemo.SOAP.Contracts.Response;

namespace SoapDemo;

public class WeatherForecastController(ILogger<WeatherForecastController> logger) : BaseApiController
{
    private readonly ILogger<WeatherForecastController> _logger = logger;

    [HttpGet("sample")]
    [Consumes("application/xml")]
    [Produces("application/xml")]
    public IActionResult GetSampleXml(SOAPRequestEnvelope<GetSampleXmlRequestBody> env)
    {
        _logger.LogInformation("Start getting xml sample response");

        var responseBody = new GetSampleXmlResponseBody
        {
            GetSampleXmlResponse = new GetSampleXmlResponse
            {
                SampleXmlResponses = Enumerable.Range(1, 5).Select(i => new SampleXmlResponse()).ToList()
            }
        };

        var envelope = new SOAPResponseEnvelope<GetSampleXmlResponseBody>()
        {
            Body = responseBody
        };

        var serializer = new XmlSerializer(typeof(SOAPResponseEnvelope<GetSampleXmlResponseBody>));
        using var writer = new StringWriter();
        serializer.Serialize(writer, envelope);
        var xmlString = writer.ToString();

        return new ContentResult
        {
            Content = xmlString,
            ContentType = "application/xml",
            StatusCode = 200
        };
    }

    [HttpGet("negative-list")]
    [Consumes("application/xml", "application/json")]
    [Produces("application/xml", "application/json")]
    public List<int> GetAListOfNegativeNumber(SOAPRequestEnvelope<GetNegativeNumberListRequestBody> env)
    {
        _logger.LogInformation("Start getting xml sample response");
        return Enumerable.Range(-1, 10).ToList();
    }

    [HttpGet("json")]
    public IEnumerable<SampleJsonResponse> GetJson()
    {
        _logger.LogInformation("Start to posting json sample response");
        return Enumerable.Range(1, 5).Select(i => new SampleJsonResponse());
    }
}
