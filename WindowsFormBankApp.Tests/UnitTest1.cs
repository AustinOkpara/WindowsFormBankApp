
using BankApp.Implementations;

namespace WindowsFormBankApp.Tests
{
    [TestFixture]
    public class Tests
    {
        
        public void Setup()
        {
        }

        [Test]
        public void EmailValidation()
        {
            var result = new Validation();

            var expected = "stinzy94@gmail.com";

            var actual = result.ValidateEmail(expected);

            Assert.IsTrue(actual);

            //public void PasswordValidation()
            //{
            //    var result = new Validation();

            //    var expected = "2123abc";

            //    var actual = result.ValidatePassword(expected);

            //    Assert.IsTrue(actual);
            //}
        }

    }  

}