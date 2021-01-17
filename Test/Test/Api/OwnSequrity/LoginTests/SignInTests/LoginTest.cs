using NUnit.Framework;
using RestSharp;
using System;

namespace Test.Test.Api.OwnSequrity.LoginTests.SignInTests
{
    class LoginTest
    {
        [Test]
        public void SignInApiTest()
        {
            IRestClient client = new RestClient("https://greencity.azurewebsites.net/ownSecurity/signIn");
            IRestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\n\"email\": \"pruvat@gmail.com\",\n\"password\": \"1Test@test\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}