using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegexProblem
{
    [TestClass]
    public class MSTestUC10
    {
        string result;
        ValidateUserUC10 validateUserUC10 = new ValidateUserUC10();
        
        [TestMethod]
        public void check_First_Name()
        {
            result = validateUserUC10.ValidateFirstName("Hari");
            Assert.AreEqual("Happy",result);
        }
        
        [TestMethod]
        public void check_Last_Name()
        {
            result = validateUserUC10.ValidateFirstName("Kumar");
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        public void check_Email()
        {
            result = validateUserUC10.ValidateFirstName("erjprakash22@gmail.com");
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        public void check_Phone_Number()
        {
            result = validateUserUC10.ValidateFirstName("7008725250");
            Assert.AreEqual("Sad", result);
        }

        [TestMethod]
        public void check_Password()
        {
            result = validateUserUC10.ValidateFirstName("Birdin@theSky");
            Assert.AreEqual("Happy", result);
        }
    }
}
