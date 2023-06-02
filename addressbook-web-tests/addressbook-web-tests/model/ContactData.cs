using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WebAddressBookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public ContactData()
        { }


        private string nickName;
        private string title;
        private string company;
        private string address;

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
        private string allEmails;
        private string allPhones;
        private string allAddres;
        private string allData;
        private string firstNameLastNameAddress;
        private string homeMobileWorkPhone;
        private string homeMobileWorkPhones;

        public ContactData(string lastName)
        {
            LastName = lastName;
        }
        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return LastName == other.LastName && FirstName == other.FirstName;

        }
        public override string ToString()
        {
            return FirstName + LastName;

        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() + FirstName.GetHashCode();
        }
        public int CompareTo(ContactData other)
        {
            if (other is null)
            {
                return 1;
            }
            if (this.LastName == other.LastName)
            {

                return this.FirstName.CompareTo(other.FirstName);
            }
            return this.LastName.CompareTo(other.LastName);
        }



        public ContactData(string firstName, string lastName)
        {
            FirstName = firstName;
            //MiddleName = middleName;
            LastName = lastName;
            // NickName = nickName;
            //Title = title;
            // Company = company;
            //Address = address;
            //TelephoneHome = telephoneHome;
            //Home = home;
            //Mobile = mobile;
            //Work = work;
            // Fax = fax;
            //Email = email;
            // Email2 = email2;
            // Email3 = email3;
            //HomePage = homePage;
            // SecondaryAddress = secondaryAddress;
            //SecondaryHome = secondaryHome;
            // SecondaryNotes = secondaryNotes;
            // Birthday = birthday;
            // Anniversary = anniversary;
        }

        // public ContactData(string lastName, string text) : this(lastName)
        // {
        // }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }



        public string NickName { get; set; }

        public string Title { get; set; }

        public string Company { get; set; }

        public string Address { get; set; }

        public string TelephoneHome { get; set; }

        public string Home { get; set; }

        public string Mobile { get; set; }

        public string Work { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Email2 { get; set; }

        public string Email3 { get; set; }

        public string HomePage { get; set; }

        public string SecondaryAddress { get; set; }

        public string SecondaryHome { get; set; }

        public string SecondaryNotes { get; set; }

        public string Birthday { get; set; }

        public string Anniversary { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }
       
        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUpPhone(Home) + CleanUpPhone(Mobile) + CleanUpPhone(Work)).Trim();
                }
            }
            set
            {
                allPhones = value;
            }
        }

        private string CleanUpPhone(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }
            return Regex.Replace(phone, "[ -()]", "") + "\r\n";
        }
        public string AllEmails
        {
            get
            {
                if (allEmails != null)
                {
                    return allEmails;
                }
                else
                {
                    return (CleanUpEmail(Email) + CleanUpEmail(Email2) + CleanUpEmail(Email3)).Trim();
                }
            }
            set
            {
                allEmails = value;
            }
        }
        private string CleanUpEmail(string email)
        {
            if (email == null || email == "")
            {
                return "";
            }
            return email + "\r\n";
        }
        public string AllAddres
        {
            get
            {
                if (allAddres != null)
                {
                    return allAddres;
                }
                else
                {
                    return (CleanUpAddres(Home) + CleanUpAddres(Mobile) + CleanUpAddres(Work)).Trim();
                }
            }
            set
            {
                allPhones = value;
            }
        }
        public string AllData
        {
            get
            {
                if (allData != null)
                {
                    return allData;
                }
                else
                {
                    return CleanUpFirstNameAddress(FirstNameLastNameAddress) + CleanUpAllPhones(HomeMobileWorkPhones) + CleanUpAll3Email(AllEmails);
                }
            }
            set
            {
                allData = value;
            }
        }

        private string CleanUpAllPhones(string homeMobileWorkPhones)
        {
            if (homeMobileWorkPhones == null || homeMobileWorkPhones == "")
            {
                return "";
            }
            else
            {
                if (homeMobileWorkPhones != null || homeMobileWorkPhones != "")
                {
                    if (FirstNameLastNameAddress == null || FirstNameLastNameAddress == "")
                    {
                        return homeMobileWorkPhones;
                    }
                }
            }
            return "\r\n\r\n" + homeMobileWorkPhones;
        }


        private object CleanUpAll3Email(string allEmails)
        {
            {
                if (allEmails == null || allEmails == "")
                {
                    return "";
                }
                else
                {
                    if (allEmails != null || allEmails != "")
                    {
                        if (FirstNameLastNameAddress == null || FirstNameLastNameAddress == "")
                        {
                            if (homeMobileWorkPhones == null || homeMobileWorkPhones == "")
                            {
                                return allEmails;
                            }
                        }
                    }
                }
                return "\r\n\r\n" + allEmails;
            }
        }



        private string CleanUpFirstNameAddress(string firstNameLastNameAddress)
        {
            if (firstNameLastNameAddress == null || firstNameLastNameAddress == "")
            {
                return "";
            }
            return firstNameLastNameAddress;
        }

        private string CleanUpAddres(string addres)
        {  if (addres == null || addres == "")
            {
                return "";
            }
           return addres + "\r\n";
        }


    
        private string CheckNewLineNeeded(string v)
        {
            if (Address == null || Address == "")
            {
                return null;
            }
            else
            {
                if (Address != null || Address == "")
                {
                    if (FirstName != null || FirstName == "")
                    {
                        if (LastName == null || LastName == "")
                        {
                            return "\r\n";
                        }
                    }
                }
                if (FirstName == null || FirstName == "")
                {
                    if (LastName == null || LastName == "")
                    {
                        return "\r\n";
                    }
                }
            }
            return "\r\n";
        }


        public string FirstNameLastNameAddress
        {
            get
            {
                if (firstNameLastNameAddress != null)
                {
                    return firstNameLastNameAddress;
                }
                else
                {

                    return FirstName + CheckIfSpaceNeeded(" ") + LastName + CheckNewLineNeeded("\r\n") + Address.Trim();
                }
            }
            set
            {
                firstNameLastNameAddress = value;
            }
        }
    
        public string HomeMobileWorkPhones 
        {
            get
            {
                if (homeMobileWorkPhones != null)
                {
                    return homeMobileWorkPhones;
                }
                else
                {
                    return AddedH(Home) + CheckNewLineBeforeM("\r\n")+
                    AddedM(Home) + CheckNewLineBeforeW("\r\n") + AddedW(Work);
                }
            }
            set { 
                homeMobileWorkPhones = value; 
            }
            }

        private string AddedW(string work)
        {
            if (Work == null || Work == "")
            {
                return "";
            }
            return "W: "+Work;
        }

        private string AddedM(string telephoneHome)
        {
            if (Mobile == null || Mobile == "")
            {
                return "";
            }
            return "M: "+Mobile;
        }

        private string AddedH(string telephoneHome)
        {
            if (Home == null || Home == "")
            {
                return "";
            }
            return "H: "+Home;
        }

        private string CheckNewLineBeforeW(string v)
        {
            if (Work == null || Work == "")
            {
                return null;
            }
            else
            {
                if (Work != null || Work != "")
                {
                    if (Mobile != null || Mobile != "")
                    {
                        return "\r\n";
                    }
                }
                return null;
            }

        }

        private string CheckNewLineBeforeM(string v)
        {
            if (Mobile == null || Mobile == "")
            {
                return null;
            }
            else
            {
                if (Mobile != null || Mobile != "")
                {
                    if (Home != null || Home != "")
                    {
                        return "\r\n";
                    }
                }
                return null;
            }

        }

        private string CheckIfSpaceNeeded(string v)
        {
            if (FirstName == null || FirstName == "")
            {
                return null;
            }
            if (LastName == null || LastName == "")
            {
                return null;
            }
            else
            {
                return " ";
            }
        }

    }
    }