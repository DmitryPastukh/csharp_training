using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string nickName;
        private string title;
        private string company;
        private string address;
        private string telephoneHome;
        private string home;
        private string mobile;
        private string work;
        private string fax;
        private string email;
        private string email2;
        private string email3;
        private string homePage;
        private string secondaryAddress;
        private string secondaryHome;
        private string secondaryNotes;
        private string birthday;
        private string anniversary;

        public string Lastname { get; private set; }

        public ContactData(string lastName)
        {
            this.lastName = lastName;
        }
        public bool Equals(ContactData other)
        {
            if (other is null)
            {
                return false;
            }
            return lastName == other.lastName && firstName == other.firstName;
                
            

        }
        public ContactData(string firstName, string middleName, string lastName, string nickName, string title, string company, string address, string telephoneHome, string home, string mobile, string work, string fax, string email, string email2, string email3, string homePage, string secondaryAddress, string secondaryHome, string secondaryNotes, string birthday, string anniversary)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.nickName = nickName;
            this.title = title;
            this.company = company;
            this.address = address;
            this.telephoneHome = telephoneHome;
            this.home = home;
            this.mobile = mobile;
            this.work = work;
            this.fax = fax;
            this.email = email;
            this.email2 = email2;
            this.email3 = email3;
            this.homePage = homePage;
            this.secondaryAddress = secondaryAddress;
            this.secondaryHome = secondaryHome;
            this.secondaryNotes = secondaryNotes;
            this.birthday = birthday;
            this.birthday = anniversary;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }

        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

       
        public string NickName
        {
            get
            {
                return nickName;
            }
            set
            {
                nickName = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string TelephoneHome
        {
            get
            {
                return telephoneHome;
            }
            set
            {
                telephoneHome = value;
            }
        }
        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }
        }
        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }
        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }
        public string HomePage
        {
            get
            {
                return homePage;
            }
            set
            {
                homePage = value;
            }
        }
        public string SecondaryAddress
        {
            get
            {
                return secondaryAddress;
            }
            set
            {
                secondaryAddress = value;
            }
        }
        public string SecondaryHome
        {
            get
            {
                return secondaryHome;
            }
            set
            {
                secondaryHome = value;
            }
        }
        public string SecondaryNotes
        {
            get
            {
                return secondaryNotes;
            }
            set
            {
                secondaryNotes = value;
            }
        }
         public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public string Anniversary
        {
            get
            {
                return anniversary;
            }
            set
            {
                anniversary = value;
            }
        }
    }
}

