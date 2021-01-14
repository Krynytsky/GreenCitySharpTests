using System.Net;
using NUnit.Framework;
using RestSharp;

namespace Test.rest
{
    
    class RestTests
    {
        private string baseUrl = "http://api.zippopotam.us";

        [TestCase(HttpStatusCode.OK, TestName = "Check status code for NL zip code 7411")]
        [TestCase(HttpStatusCode.NotFound, TestName = "Check status code for LV zip code 1050")]
        [Test]
        public void MethodGetStatusCodeTest(HttpStatusCode expectedHttpStatusCode)
        {
            IRestClient restClient = new RestClient(baseUrl);
            IRestRequest restRequest = new RestRequest("nl/3ff5", Method.GET);

            IRestResponse restResponse = restClient.Execute(restRequest);

            Assert.That(restResponse.StatusCode, Is.EqualTo(expectedHttpStatusCode));
        }
    }
}
