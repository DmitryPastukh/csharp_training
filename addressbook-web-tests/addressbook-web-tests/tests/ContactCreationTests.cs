using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        

        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contact.InitNewContactCreation();
            ContactData contact = new ContactData("");
            contact.LastName = "Иванов";
            contact.MiddleName = "";
            contact.FirstName = "Иван";
            contact.Address = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.NickName = "";
            contact.Title = "";
            contact.Company = "";
            contact.TelephoneHome = "";
            contact.Mobile = "";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.HomePage = "";
            contact.SecondaryAddress = "";
            contact.SecondaryHome = "";
            contact.SecondaryNotes = "";
            app.Contact.FillContactForm(contact);
            app.Contact.SubmitContactCreation();
            app.Navigator.ReturToHomePage();
            app.Auth.Logout();
        }

       
        }
    }

