using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jaga.Sample.Data.Repositories;
using Jaga.Sample.Data.Entity;
namespace Jaga.Sample.Data.Tests
{
    [TestClass]
    public class UserRepositoryTests
    {
        [TestInitialize()]
        public void Setup()
        {
           
        }
        [TestMethod]
        public void GetById_Should_Return_User()
        {
            var userRepository = new UserRepository();


            for (var i = 0; i < 10; i++)
            {
                var newuser = new User() { Id = Guid.NewGuid(), Firstname = string.Format("{0}-{1}", "test", i), Surname = "user", Username = string.Format("test.user{0}@testingnew.com", i), DateOfBirth = DateTime.Parse("2001-07-01") };
                userRepository.Add(newuser);
            }

            var newGuid = Guid.NewGuid();
            var user = new User() { Id = newGuid, Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth = DateTime.Parse("2001-07-01") };
            userRepository.Add(user);

            Assert.AreEqual(11, userRepository.GetAll().Count);
            var userResult = userRepository.GetById(newGuid);
            Assert.IsNotNull(userResult);
            Assert.AreEqual(newGuid, userResult.Id);
            Assert.AreEqual(user.Firstname, userResult.Firstname);
            Assert.AreEqual(user.Username, userResult.Username);
        }
        [TestMethod]
        public void GetAll_Should_Return_AllResults()
        {
            var userRepository = new UserRepository();
            var newGuid = Guid.NewGuid();
            var user = new User() { Id = newGuid, Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth = DateTime.Parse("2001-07-01") };
            userRepository.Add(user);

            for (var i = 0; i < 10; i++)
            {
                var newuser = new User() { Id = Guid.NewGuid(), Firstname = string.Format("{0}-{1}", "test", i), Surname = "user", Username = string.Format("test.user{0}@testingnew.com", i), DateOfBirth = DateTime.Parse("2001-07-01") };
                userRepository.Add(newuser);
            }

            Assert.AreEqual(11, userRepository.GetAll().Count);

        }

        [TestMethod]
        public void Add_Should_Add_New_User()
        {
            var userRepository = new UserRepository();
            var newGuid = Guid.NewGuid();
            var user = new User() { Id = newGuid, Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth =DateTime.Parse("2001-07-01") };
            userRepository.Add(user);
            var userResult= userRepository.GetById(newGuid);
            Assert.IsNotNull(userResult);
            Assert.AreEqual(newGuid, userResult.Id);
            Assert.AreEqual(user.Firstname, userResult.Firstname);
            Assert.AreEqual(user.Username, userResult.Username);
        }
        [TestMethod]
        public void Update_Should_Update_User()
        {
            var userRepository = new UserRepository();
            var newGuid = Guid.NewGuid();
            var user = new User() { Id = newGuid, Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth = DateTime.Parse("2001-07-01") };
            userRepository.Add(user);

            for (var i = 0; i < 10; i++)
            {
                var newuser = new User() { Id = Guid.NewGuid(), Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth = DateTime.Parse("2001-07-01") };
                userRepository.Add(newuser);
            }

            var userResult = userRepository.GetById(newGuid);
            userResult.Firstname = "Test Updated";
            userRepository.Update(userResult);
            var userUpdatedResult = userRepository.GetById(newGuid);
            Assert.IsNotNull(userResult);
            Assert.AreEqual(newGuid, userResult.Id);
            Assert.AreEqual(user.Firstname, userResult.Firstname);
            Assert.AreEqual(user.Username, userResult.Username);
            Assert.AreEqual(true, userResult.ModifiedState);

        }
        [TestMethod]
        public void Delete_ByEntity_Should_Remove_User()
        {
            var userRepository = new UserRepository();
            var newGuid = Guid.NewGuid();
            var user = new User() { Id = newGuid, Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth = DateTime.Parse("2001-07-01") };
            userRepository.Add(user);

            for (var i = 0; i < 10; i++)
            { 
                var newuser = new User() { Id = Guid.NewGuid(), Firstname = string.Format("{0}-{1}", "test",i), Surname = "user", Username = string.Format("test.user{0}@testingnew.com", i), DateOfBirth = DateTime.Parse("2001-07-01") };
                userRepository.Add(newuser);
            }
            
            Assert.AreEqual(11, userRepository.GetAll().Count);
            userRepository.DeleteById(newGuid);
            Assert.AreEqual(10, userRepository.GetAll().Count);
            var userResult = userRepository.GetById(newGuid);
            Assert.IsNull(userResult);
      
        }

        [TestMethod]
        public void Delete_ById_Should_Remove_User()
        {
            var userRepository = new UserRepository();
            var newGuid = Guid.NewGuid();
            var user = new User() { Id = newGuid, Firstname = "test", Surname = "user", Username = "test.user@testingnew.com", DateOfBirth = DateTime.Parse("2001-07-01") };
            userRepository.Add(user);

            for (var i = 0; i < 10; i++)
            {
                var newuser = new User() { Id = Guid.NewGuid(), Firstname = string.Format("{0}-{1}", "test", i), Surname = "user", Username = string.Format("test.user{0}@testingnew.com", i), DateOfBirth = DateTime.Parse("2001-07-01") };
                userRepository.Add(newuser);
            }

            Assert.AreEqual(11, userRepository.GetAll().Count);
            var userToDelete=userRepository.GetById(newGuid);
            userRepository.Delete(userToDelete);
            Assert.AreEqual(10, userRepository.GetAll().Count);
            var userResult = userRepository.GetById(newGuid);
            Assert.IsNull(userResult);

        }

    }
}
