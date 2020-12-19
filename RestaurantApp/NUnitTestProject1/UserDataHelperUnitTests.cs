using NUnit.Framework;
using RestaurantApp.Helpers;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSetUp()
        {
            try
            {
                UserDataHelper userDataHelper = new UserDataHelper();
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void TestGetDefaultUser()
        {
            try
            {
                UserDataHelper userDataHelper = new UserDataHelper();
                var user = userDataHelper.GetUserData("DefaultUser");

                if (user == null)
                {
                    Assert.Fail();
                }
                Assert.AreEqual("DefaultUser", user.UserName);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}