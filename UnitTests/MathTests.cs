using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTestApp;

namespace UnitTests
{
    [TestClass]
    public class MathTests1
    {
        // Addition //
        
        [TestMethod]
        public void Addition_Min()
        {
            int ReturnValue = Math.Addition(-1000000000, -1000000000);
            Assert.AreEqual(ReturnValue, -2000000000);
        }

        [TestMethod]
        public void Addition_Mid()
        {
            int ReturnValue = Math.Addition(5, 5);
            Assert.AreEqual(ReturnValue, 10);
        }

        [TestMethod]
        public void Addition_Max()
        {
            int ReturnValue = Math.Addition(1073741823, 1073741823);
            Assert.AreEqual(ReturnValue, 2147483646);
        }

        /*[TestMethod]
        public void Addition_Overflow()
        {
            try
            {
                int ReturnValue = Math.Addition(unchecked(1073741850), unchecked(1073741850));
                //Assert.Ar(ReturnValue, 2147483700);
            }
            catch(System.Exception ex)
            {
                Assert.AreEqual(ex.Message, "Test");
            }
        }*/

        // Subtraction //

        [TestMethod]
        public void Subtraction_Min()
        {
            int ReturnValue = Math.Subtraction(-1000000000, -1000000000);
            Assert.AreEqual(ReturnValue, 0);
        }

        [TestMethod]
        public void Subtraction_Mid()
        {
            int ReturnValue = Math.Subtraction(30, 10);
            Assert.AreEqual(ReturnValue, 20);
        }

        [TestMethod]
        public void Subtraction_Max()
        {
            int ReturnValue = Math.Subtraction(1073741823, 1073741800);
            Assert.AreEqual(ReturnValue, 23);
        }

        /*[TestMethod]
        public void Subtraction_Overflow()
        {
            try
            {
                int ReturnValue = Math.Addition(unchecked(1073741850), unchecked(1073741850));
                //Assert.Ar(ReturnValue, 2147483700);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual(ex.Message, "Test");
            }
        }*/

        // Multiplication //

        [TestMethod]
        public void Multiplication_Min()
        {
            int ReturnValue = Math.Multiplication(-32767, -32767);
            Assert.AreEqual(ReturnValue, 1073676289);
        }

        [TestMethod]
        public void Multiplication_Mid()
        {
            int ReturnValue = Math.Multiplication(5, 5);
            Assert.AreEqual(ReturnValue, 25);
        }

        [TestMethod]
        public void Multiplication_Max()
        {
            int ReturnValue = Math.Multiplication(32767, 32767);
            Assert.AreEqual(ReturnValue, 1073676289);
        }

        /*[TestMethod]
        public void Multiplication_Overflow()
        {
            try
            {
                int ReturnValue = Math.Multiplication(unchecked(1073741850), unchecked(1073741850));
                //Assert.Ar(ReturnValue, 2147483700);
            }
            catch(System.Exception ex)
            {
                Assert.AreEqual(ex.Message, "Test");
            }
        }*/

        // Division //

        [TestMethod]
        public void Division_Min()
        {
            int ReturnValue = Math.Division(-1000000000, -1000000000);
            Assert.AreEqual(ReturnValue, 1);
        }

        [TestMethod]
        public void Division_Mid()
        {
            int ReturnValue = Math.Division(30, 10);
            Assert.AreEqual(ReturnValue, 3);
        }

        [TestMethod]
        public void Division_Max()
        {
            int ReturnValue = Math.Division(1073741000, 1000);
            Assert.AreEqual(ReturnValue, 1073741);
        }

        [TestMethod]
        public void Division_DivByZero()
        {
            try
            {
                int ReturnValue = Math.Division(1, 0);
                Assert.IsTrue(false);
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual(ex.Message, "Attempted to divide by zero.");
            }
        }
    }
}
