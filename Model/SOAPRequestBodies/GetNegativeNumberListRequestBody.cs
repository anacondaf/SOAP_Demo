using SoapDemo.SOAP.Contracts.Request;

namespace SoapDemo.Model.SOAPRequestBodies;

public class GetNegativeNumberListRequestBody : SOAPRequestBody
{
    public override string DefaultNamespace => "http://example.com/service2/";
    public override string DefaultNamespacePrefix => "ser2";
}