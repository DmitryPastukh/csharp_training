﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {


        [Test]
        public void ContactRemovalTest()
        {

            app.Contact.Remove(1);
            app.Auth.Logout();
        }

    }
}