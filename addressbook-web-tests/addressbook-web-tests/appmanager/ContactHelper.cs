using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class ContactHelper : HelperBase
    {



        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }
        public ContactHelper Create(ContactData contact)
        {

            manager.Navigator.GoToHomePage();
            InitNewContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();


            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            contactCache = null;
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("lastname"), contact.LastName);
            // Type(By.Name("middlename"), contact.MiddleName);
            // Type(By.Name("nickname"), contact.NickName);
            // Type(By.Name("title"), contact.Title);
            //Type(By.Name("company"), contact.Company);
            //Type(By.Name("address"), contact.Address);
            // Type(By.Name("home"), contact.Home);
            // Type(By.Name("mobile"), contact.Mobile);
            // Type(By.Name("work"), contact.Work);
            // Type(By.Name("fax"), contact.Fax);
            //Type(By.Name("email"), contact.Email);
            // Type(By.Name("email2"), contact.Email2);
            //Type(By.Name("email3"), contact.Email3);
            // Type(By.Name("homepage"), contact.HomePage);
            // Type(By.Name("byear"), contact.Birthday);
            //Type(By.Name("ayear"), contact.Anniversary);
            // Type(By.Name("address2"), contact.SecondaryAddress);
            //Type(By.Name("phone2"), contact.SecondaryHome);
            //Type(By.Name("notes"), contact.SecondaryNotes);



            return this;
        }
        public ContactHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();

            return this;
        }

        internal ContactHelper Modify(int index, ContactData newData)
        {
            manager.Navigator.GoToHomePage();

            InitContactModification(index);
            FillContactForm(newData);
            SubmitContactModification();
            return this;

        }

        private ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//*[@name='update'])[1]")).Click();
            contactCache = null;
            return this;
        }

        private ContactHelper InitContactModification(int index)
        {
            driver.FindElement(By.XPath("(//*[@title='Edit'])[" + (index + 1) + "]")).Click();
            return this;
        }
        public ContactHelper Remove(int p)
        {

            manager.Navigator.GoToHomePage();

            SelectContact(p);
            RemoveContact();
            driver.SwitchTo().Alert().Accept();


            return this;
        }

        private ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//*[@value='Delete']")).Click();
            contactCache = null;
            return this;
        }

        private ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();
            return this;
        }
        public ContactHelper SelectContact(String id)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]' and @value='" + id + "'])")).Click();
            return this;
        }
        public ContactHelper CheckContact()
        {
            manager.Navigator.GoToHomePage();
            ContactData contact = new ContactData("");
            if (IsElementPresent(By.Name("selected[]")))
            {
                return this;
            }

            contact.LastName = "тест";
            // contact.MiddleName = "тест";
            contact.FirstName = "тест";
            // contact.Address = "тест";
            // contact.Email = "тест";
            // contact.Email2 = "тест";
            // contact.NickName = "тест";
            // contact.Title = "тест";
            // contact.Company = "тест";
            // contact.TelephoneHome = "тест";
            // contact.Mobile = "тест";
            // contact.Work = "тест";
            //  contact.Fax = "тест";
            //  contact.Email = "тест";
            //  contact.Email2 = "тест";
            //  contact.Email3 = "тест";
            //  contact.HomePage = "тест";
            // contact.SecondaryAddress = "тест";
            //  contact.SecondaryHome = "тест";
            //  contact.SecondaryNotes = "ooтестoo";
            //  contact.Birthday = "тест";
            // contact.Anniversary = "тест";
            // contact.Home = "тест";
            Create(contact);
            manager.Navigator.GoToHomePage();
            return this;
        }
        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactList()
        {
            if (contactCache == null)
            {
                contactCache = new List<ContactData>();


                manager.Navigator.GoToHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.Name("entry"));
                foreach (IWebElement element in elements)
                {
                    IList<IWebElement> cells = element.FindElements(By.TagName("td"));
                    contactCache.Add(new ContactData(cells[2].Text, cells[1].Text));

                }
            }

            return new List<ContactData>(contactCache);
        }
        public int GetContactCount()
        {
           manager.Navigator.ReturToHomePage();
            return driver.FindElements(By.Name("entry")).Count;
        }


    }
}