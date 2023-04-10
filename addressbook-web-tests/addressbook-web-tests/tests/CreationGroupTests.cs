﻿using System;
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

            
           
            GroupData group = new GroupData("aaa");
             
            group.Header = "ddd";
            group.Footer = "fff";
           
            app.Groups.Create(group);
            

        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
             app.Groups.Create(group);
            
        }
    }

       
    }
