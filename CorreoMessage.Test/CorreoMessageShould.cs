using CorreoTestLemonCode;

namespace CorreoMessage.Test
{
    [TestClass]
    public class CorreoMessageShould
    {
        [TestMethod]
        public void Return_Ok_When_Mail_Valid()
        {
            //Arrange
            var mailValidator = new EmailValidator();

            //Act de los que se espera que sin problemas
            var mockEmail = "jorge@gmail.com";
            var mockEmail2 = "prueba@yahoo.com";
            var mockEmail3 = "lemoncode@hotmail.com";

            //Assert de los que se esperan que sin problemas
            Assert.IsTrue(mailValidator.ValidarCorreo(mockEmail));
            Assert.IsTrue(mailValidator.ValidarCorreo(mockEmail2));
            Assert.IsTrue(mailValidator.ValidarCorreo(mockEmail3));
        }

        [TestMethod]
        public void Return_Ok_When_Mail_NotValid()
        {
            //Arrange
            var mailValidator = new EmailValidator();

            //Act de los que se espera error
            var mockEmailFalse1 = "jorge@hola.com";
            var mockEmailFalse2 = "prueba@pipas.com";
            var mockEmailFalse3 = "lemoncode@limon.com";

            //Assert de los que esperan que den error
            Assert.IsFalse(mailValidator.ValidarCorreo(mockEmailFalse1));
            Assert.IsFalse(mailValidator.ValidarCorreo(mockEmailFalse2));
            Assert.IsFalse(mailValidator.ValidarCorreo(mockEmailFalse3));
        }


           
        
    }
} 