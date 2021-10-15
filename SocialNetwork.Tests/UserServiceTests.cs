using NUnit.Framework;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using System;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void FindByEmailMustThrowException()
        {
            var userServiceTest = new UserService();
            Assert.Throws<UserNotFoundException>(() => userServiceTest.FindByEmail("@mail.ru"));
        }
        [Test]
        public void RegisterMustThrowException()
        {
            var userServiceTest = new UserService();
            var userRegistrationData = new UserRegistrationData()
            {
                FirstName = "",
                LastName = "",
                Password = "",
                Email = ""
            };
            Assert.Throws<ArgumentNullException>(() => userServiceTest.Register(userRegistrationData));

            var userRegistrationData2 = new UserRegistrationData()
            {
                FirstName = "Gosha",
                LastName = "Dzen",
                Password = "1234",
                Email = "gd@mail.ru"
            };
            Assert.Throws<ArgumentNullException>(() => userServiceTest.Register(userRegistrationData2));

            var userRegistrationData3 = new UserRegistrationData()
            {
                FirstName = "Gosha",
                LastName = "Dzen",
                Password = "12345678",
                Email = "gdmail.ru"
            };
            Assert.Throws<ArgumentNullException>(() => userServiceTest.Register(userRegistrationData3));
        }
    }
}