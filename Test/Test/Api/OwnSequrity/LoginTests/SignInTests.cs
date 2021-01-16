using NUnit.Framework;
using RestSharp;
using System;


namespace Test.Test.Api.OwnSequrity.LoginTests
{
    class SignInTests
    {
        [Test]
        public void SignInApiTest()
        {
            var client = new RestClient("https://greencity.azurewebsites.net/ownSecurity/signIn");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\n    \"email\": \"pruvat@gmail.com\",\n    \"password\": \"1Test@test\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
