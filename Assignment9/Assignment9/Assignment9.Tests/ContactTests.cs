using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment9.Tests
{
    [TestClass]
    public class ContactTests
    {

        [TestMethod]
        public void ContactViewModel_SettingFirstName_ReturnsSetValue()
        {
            MainWindowViewModel mvvm = new();
            Assert.AreEqual<string>("Jenny", mvvm.CurrentContact.FirstName!);
            mvvm.CurrentContact.FirstName = "Test";
            Assert.AreEqual<string>("Test", mvvm.CurrentContact.FirstName);
        }

        [TestMethod]
        public void ContactViewModel_SettingLastName_ReturnsSetValue()
        {
            MainWindowViewModel mvvm = new();
            Assert.AreEqual<string>("Tutone", mvvm.CurrentContact.LastName!);
            mvvm.CurrentContact.LastName = "Test";
            Assert.AreEqual<string>("Test", mvvm.CurrentContact.LastName);
        }

        [TestMethod]
        public void ContactViewModel_SettingPhoneNumber_ReturnsSetValue()
        {
            MainWindowViewModel mvvm = new();
            Assert.AreEqual<string>("(509)867-5309", mvvm.CurrentContact.PhoneNumber!);
            mvvm.CurrentContact.PhoneNumber = "Test";
            Assert.AreEqual<string>("Test", mvvm.CurrentContact.PhoneNumber);
        }

        [TestMethod]
        public void ContactViewModel_SettingEmailAddress_ReturnsSetValue()
        {
            MainWindowViewModel mvvm = new();
            Assert.AreEqual<string>("numberonthewall@gmail.com", mvvm.CurrentContact.EmailAddress!);
            mvvm.CurrentContact.EmailAddress = "Test";
            Assert.AreEqual<string>("Test", mvvm.CurrentContact.EmailAddress);
        }

        [TestMethod]
        public void ContactViewModel_SettingTwitterName_ReturnsSetValue()
        {
            MainWindowViewModel mvvm = new();
            Assert.AreEqual<string>("@foragoodtimecall", mvvm.CurrentContact.TwitterName!);
            mvvm.CurrentContact.TwitterName = "Test";
            Assert.AreEqual<string>("Test", mvvm.CurrentContact.TwitterName);
        }

        [TestMethod]
        public void ContactViewModel_SettingLastModifiedTime_ReturnsSetValue()
        {
            MainWindowViewModel mvvm = new();
            DateTime timeSet = DateTime.Now;
            mvvm.CurrentContact.LastModifiedTime = timeSet;
            Assert.AreEqual<DateTime>(timeSet, mvvm.CurrentContact.LastModifiedTime);
        }
    }
}
