using Module12_API.Utils;
using NUnit.Framework;
using System.Net;

namespace Module12_API.Tests
{
    [TestFixture]
    [Parallelizable]
    public class GetUsersStatusTest
    {
        [Test]
        public void UsersStatusTest()
        {
            //Act
            HttpWebResponse response = RequestUtils.GetRequestResponse(RequestUtils.userEndpoint, RequestUtils.getRequest);

            //Assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
