using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {


        [Test]
        public void ContactModificationTest()
        {
            app.Contact.CheckContact();
             List<ContactData> oldContact = app.Contact.GetContactList();

            ContactData newData = new ContactData("");
            newData.LastName = "тест";
            newData.MiddleName = "22222";
            newData.FirstName = "s33333d333333ds";
            newData.Address = "";
            newData.Email = "";
            newData.Email2 = "";
            newData.NickName = "";
            newData.Title = "";
            newData.Company = "";
            newData.TelephoneHome = "";
            newData.Mobile = "";
            newData.Work = "";
            newData.Fax = "";
            newData.Email = "";
            newData.Email2 = "";
            newData.Email3 = "";
            newData.HomePage = "";
            newData.SecondaryAddress = "";
            newData.SecondaryHome = "";
            newData.SecondaryNotes = "";
            newData.Home = "ooooo";
            newData.Birthday = "ooooo";
            newData.Anniversary = "ooooo";
           
            
            app.Contact.Modify(0, newData);
            List<ContactData> newContact = app.Contact.GetContactList();
            oldContact[0].FirstName = newData.FirstName;
            oldContact[0].LastName = newData.LastName;
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);

            app.Navigator.ReturToHomePage();
            


        }
    }
}
