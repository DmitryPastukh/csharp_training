using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {


        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("");
            newData.LastName = "11111";
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
            app.Contact.Modify(2, newData);
            app.Navigator.ReturToHomePage();


        }
    }
}
