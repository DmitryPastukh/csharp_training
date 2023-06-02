using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    public class ContactInformationTests : AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
          ContactData fromTable =   app.Contact.GetContactInformationFromTable(0);
          ContactData fromForm = app.Contact.GetContactInformationFromEditForm(0);

            // verification
            Assert.AreEqual(fromTable, fromForm);
            Assert.AreEqual(fromForm.Address, fromTable.Address);
            Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
            Assert.AreEqual(fromTable.AllEmails, fromForm.AllEmails);
        }
        [Test]
        public void TestContactInformationFormContactProperties()
        {
            ContactData fromForm = app.Contact.GetContactInformationFromEditForm(0);
            ContactData fromProperties = app.Contact.GetContactInformationFromContactProperties(0);

            
            Assert.AreEqual(fromForm.AllData, fromProperties.AllData);
            
        }
    }
}
