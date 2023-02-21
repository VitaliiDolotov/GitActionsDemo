using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace BackTests
{
    internal class BackendTests
    {
        [Test]
        [CategoryAttribute("OnBuild")]
        public void SomeUnitTest()
        {
            var client = new RestClient("https://gorest.co.in/public/v2/");
            var request = new RestRequest("posts");
            var response = client.Get(request);

            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
        }
    }
}
