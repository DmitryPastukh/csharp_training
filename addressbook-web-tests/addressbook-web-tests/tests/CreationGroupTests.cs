using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressBookTests
{
    [TestFixture]
    public class CreationGroupTests : AuthTestBase
    {
        

        [Test]
        public void CreationGroupTest()
        {

            
           
            GroupData group = new GroupData("jjjj");
             
            group.Header = "ddd";
            group.Footer = "fff";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            

            app.Groups.Create(group);
            
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups.Count, newGroups.Count+1);




        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            
            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }
        [Test]
        public void BadNameGroupCreationTest()
        {
            GroupData group = new GroupData("a'a");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }
    }

       
    }

