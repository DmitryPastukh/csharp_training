using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {


        [Test]
        public void ContactRemovalTest()
        {
             
            app.Contact.CheckContact();
            List<ContactData> oldContact = app.Contact.GetContactList();
            ContactData toBeRemoved = oldContact[0];

            
            app.Contact.Remove(0);
            Assert.AreEqual(oldContact.Count - 1, app.Contact.GetContactCount());

            List<ContactData> newContact = app.Contact.GetContactList();
            
            oldContact.RemoveAt(0);
           // oldContact[0].FirstName = newData.FirstName;
           // oldContact[0].LastName = newData.LastName;
           // oldContact.Sort();
           // newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
            foreach (ContactData contact in newContact)
            {
                Assert.AreNotEqual(contact.Id, toBeRemoved.Id);

            }

        }

    }
}
