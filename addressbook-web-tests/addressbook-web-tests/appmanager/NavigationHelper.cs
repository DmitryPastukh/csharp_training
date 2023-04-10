﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressBookTests
{
    public class NavigationHelper : HelperBase
    {
        //private IWebDriver driver;
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) 
            : base(manager) 
        { 
         this.baseURL = baseURL;
        }

        public NavigationHelper GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            return this;
            
        }
        public NavigationHelper GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
        public NavigationHelper ReturToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }
        
    }
}