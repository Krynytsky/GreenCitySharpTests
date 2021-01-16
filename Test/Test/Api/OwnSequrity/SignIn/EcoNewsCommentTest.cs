using NUnit.Framework;
using RestSharp;
using System;
using System.Net;

namespace Test.Test.Api.OwnSequrity.SignIn
{
    class EcoNewsCommentTest
    {

       [Test]
        public void CreationEcoNewsCommentTest()
        {
            var client = new RestClient("https://greencity.azurewebsites.net/econews/comments/8790");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJwcnV2YXRAZ21haWwuY29tIiwiYXV0aG9yaXRpZXMiOlsiUk9MRV9VU0VSIl0sImlhdCI6MTYxMDgxODc4OCwiZXhwIjoxNjEwODI1OTg4fQ.yk9K84KHuBlr0xnHTvMh7skimf2ZlHA_jORi5tHGm_Q");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\n  \"parentCommentId\": 0,\n  \"text\": \"comment from postman\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }
    }
}


