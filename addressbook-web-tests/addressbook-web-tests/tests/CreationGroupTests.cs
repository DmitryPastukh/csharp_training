using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class CreationGroupTests : TestBase
    {
        

        [Test]
        public void CreationGroupTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            app.Groups.FillGroupForm(new GroupData("aaa", "fff", "ddd"));
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToGroupsPage();
            
        }

       }

       
    }

