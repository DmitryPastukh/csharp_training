using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        

        [Test]
        public void ContactCreationTest()
        {
            
            ContactData contact = new ContactData("");
            contact.LastName = "ooooo";
            contact.MiddleName = "oooo";
            contact.FirstName = "ooo";
            contact.Address = "ooo";
            contact.Email = "oo";
            contact.Email2 = "oooo";
            contact.NickName = "oooo";
            contact.Title = "oooo";
            contact.Company = "oooo";
            contact.TelephoneHome = "oooo";
            contact.Mobile = "ooooo";
            contact.Work = "xxoooxx";
            contact.Fax = "xooooxx";
            contact.Email = "oooo";
            contact.Email2 = "oooo";
            contact.Email3 = "oooo";
            contact.HomePage = "oooo";
            contact.SecondaryAddress = "ooooo";
            contact.SecondaryHome = "xxooooxx";
            contact.SecondaryNotes = "oooo";
            contact.Birthday = "ooooo";
            contact.Anniversary = "ooooo";
            contact.Home = "ooooo";
            app.Contact.Create(contact);
            app.Navigator.ReturToHomePage();
            

        }

       
        }
    }

