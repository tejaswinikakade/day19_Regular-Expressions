using NUnit.Framework;
using UserRegistration;

namespace NUnitUserRegistration
{
    public class Tests
    {
        string firstName = "^[A-Z]{1}[a-z]{2,10}$";
        string lastName = "^[A-Z]{1}[a-z]{2,10}$";
        string email = "^[a-zA-Z0-9]{3,}[@]{1}[A-Za-z0-9]+[.]{1}[a-zA-Z]{2,4}$";
        string phoneNumber = "^(\\d{1,2}?)[- .][6-9]{1}[0-9]{9}$";
        string password1 = "^[a-zA-z]{8}$";
        string password2 = "^(?=.*[A-Z]).{8}$";
        string password3 = "^(?=.*[0-9]).{8,}$";
        string password4 = "^(?=.?[#?!@$%^&-]).{8,}$";
        string email1 = "^[a-zA-Z-9]+([._+-][0-9A-Za-z]+)@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-z]{2,4})?$";
        UserDetails fs;

        [SetUp]
        public void Setup()
        {
            fs = new UserDetails();
        }

        [Test]
        public void Test1()
        {
            var result = fs.FirstName("Tejaswini", firstName);
            Assert.AreEqual(true, result.Success);

        }
        //UC2 for last name
        [Test]
        public void Test2()
        {
            var result = fs.LastName("Kakade", lastName);
            Assert.AreEqual(true, result.Success);

        }
        //UC3 for email
        [Test]
        public void Test3()
        {
            var result = fs.Email("tejaswini123@gmail.com", email);
            Assert.AreEqual(true, result.Success);

        }
        //UC4 for phonenumber
        [Test]
        public void Test4()
        {
            var result = fs.PhoneNumber("91 8766449691", phoneNumber);
            Assert.AreEqual(true, result.Success);

        }
        //UC5 for password1
        [Test]
        public void Test5()
        {
            var result = fs.Password1("fieqrfjj", password1);
            Assert.AreEqual(true, result.Success);


        }
        //UC6 for password2 atleast one uppercase
        [Test]
        public void Test6()
        {
            var result = fs.Password2("Tejaswini1", password2);
            Assert.AreEqual(true, result.Success);

        }
        //UC7 for password3 atleast one numeric number
        [Test]
        public void Test7()
        {
            var result = fs.Password3("Tejaswini18", password3);
            Assert.AreEqual(true, result.Success);

        }
        //UC8 for password4 atleast one special character
        [Test]
        public void Test8()
        {
            var result = fs.Password4("Tejaswini#", password4);
            Assert.AreEqual(false, result.Success);

        }
        //UC9 for clear all email samples

        [Test]
        public void Test9()
        {
            var result = fs.Email1("TEjukakade1821@gmail.com", email1);
            Assert.AreEqual(false, result.Success);

        }
    }
}