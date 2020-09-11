using Vigenere.Library;
using NUnit.Framework;

namespace Test.Library
{
    public class Vigenere_LowerCaseKey
    {

        private VigenereCode vLowerCase;
        private VigenereCode vLowerCaseSalt;


        [SetUp]
        public void Setup()
        {
            vLowerCase = new VigenereCode("ucu", 0);
            vLowerCaseSalt = new VigenereCode("ucu", 5);
        }

        [Test]
        public void Decrypt_UpperCaseCode()
        {
            string result = vLowerCase.Decrypt("JTIATUGCWCQHCK");
            Assert.AreEqual("PROGRAMACIONII",result);
        }

        [Test]
        public void Decrypt_UpperCaseCode_WithSalt()
        {
            string result = vLowerCaseSalt.Decrypt("OYNFYZLHBHVMHP");
            Assert.AreEqual("PROGRAMACIONII", result);
        }

        [Test]
        public void Encrypt_UpperCaseCode()
        {
            string result = vLowerCase.Encrypt("PROGRAMACIONII");
            Assert.AreEqual("JTIATUGCWCQHCK",result);
            
        }
        [Test]
        public void Encrypt_UpperCaseCode_WithSalt()
        {
            string result = vLowerCaseSalt.Encrypt("PROGRAMACIONII");
            Assert.AreEqual("OYNFYZLHBHVMHP",result);
        }
        [Test]
        public void Decrypt_LowerCaseCode()
        {
            string result = vLowerCase.Decrypt("jtiatugcwcqhck");
            Assert.AreEqual("PROGRAMACIONII",result);
        }
        [Test]
        public void Encrypt_LowerCaseCodey()
        {
            string result = vLowerCase.Encrypt("programacionii");
            Assert.AreEqual("JTIATUGCWCQHCK",result);
        }
    }
}