using ArchiveSystem.Controllers;
using ArchiveSystem.Models;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveSystem.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void TestDbConnection()
        {
            using (var db = new ApplicationDbContext())
            {
                var isExist = db.Database.Exists();
                Assert.IsTrue(isExist);
            }
        }
        [TestMethod]
        public void RegisterTest()
        {
            using (var db = new ApplicationDbContext())
            {
                //arrange
                string password = "joshua";
                string email = "abrenicamarkjoshua@gmail.com";
                string role = "admin";
                string firstname = "Mark Joshua";
                string lastname = "Abrenica";
                RegisterViewModel registration = new RegisterViewModel()
                {
                    Password = password,
                    Email = email,
                    ConfirmPassword = password,
                     Role = role,
                      FirstName = firstname,
                      LastName = lastname
                };
                
                //act
                AccountController controller = new AccountController();

                bool output = controller.RegisterUser(registration);
                //assert
                Assert.IsTrue(output);

            }
        }
    }
}
