using Module12_API.Models;
using Module12_API.Utils;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net;

namespace Module12_API.Tests
{
    [TestFixture]
    [Parallelizable]
    class UsersResponseContent
    {
        [Test]
        public void ResponseContentTest()
        {
            //Arrange
            string response = RequestUtils.MakeGETRequest(RequestUtils.userEndpoint, HttpStatusCode.OK);

            //Act
            List<User> users = JsonConvert.DeserializeObject<List<User>>(response);

            //Assert
            Assert.AreEqual(10, users.Count);
        }
    }
}
