using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace BackTests
{
    internal class BackendTests
    {
        [Test]
        [CategoryAttribute("GreenTest")]
        public void SuccessCase()
        {
            var client = new RestClient("https://gorest.co.in/public/v2/");
            var request = new RestRequest("posts");
            var response = client.Get(request);

            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
        }


        //[Test]
        //[CategoryAttribute("RedTest")]
        //public void UnsuccessCase()
        //{
        //    var client = new RestClient("https://gorest.co.in/public/v2/");
        //    var request = new RestRequest("posts");
        //    var response = client.Get(request);

        //    response
        //        .StatusCode
        //        .Should()
        //        .Be(HttpStatusCode.Created);
        //}
    }
}
