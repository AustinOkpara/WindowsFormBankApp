
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

            
        }
        [Test]
        public void PasswordValidation()
        {
            var result = new Validation();

            var expected = "@abc123";

            var actual = result.ValidatePassword(expected);

            Assert.IsTrue(actual);


      
     
        }
        [Test]
        public void NameValidation()
        {
            var result = new Validation();

            var expected = "Austin Okpara";

            var actual = result.ValidateName(expected);

            Assert.IsTrue(actual);
        }
    }  

}  

