using Module12_API.Utils;
using NUnit.Framework;
using System.Linq;
using System.Net;

namespace Module12_API.Tests
{
    [TestFixture]
    [Parallelizable]
    class UsersHeadersTest
    {
        [Test]
        public void HeadersTest()
        {
            //Arrange
            string headerKey = "Content-Type";

            //Act
            HttpWebResponse response = RequestUtils.GetRequestResponse(RequestUtils.userEndpoint, RequestUtils.getRequest);

            //Assert
            Assert.IsTrue(response.Headers.AllKeys.Contains(headerKey), "The content-type header does not exist in the response.");
            Assert.IsTrue(response.Headers.GetValues(headerKey).Contains("application/json; charset=utf-8"), "The content-type header does not match the expected one.");
        }
    }
}
