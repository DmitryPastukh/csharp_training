using System;
using System.Collections.Generic;
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

            
            app.Contact.Remove(0);
            List<ContactData> newContact = app.Contact.GetContactList();
            oldContact.RemoveAt(0);
            
            oldContact.Sort();
            newContact.Sort();
            

            Assert.AreEqual(oldContact.Count, newContact.Count-1);
        }

    }
}
