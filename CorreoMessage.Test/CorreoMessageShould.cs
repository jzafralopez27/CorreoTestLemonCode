using CorreoTestLemonCode;
using Moq;

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
            var correoValidatorMock = new Mock<EmailValidator>();

            //Act de los que se espera que sin problemas
            var mockEmail = "jorge@gmail.com";
            var mockEmail2 = "prueba@yahoo.com";
            var mockEmail3 = "lemoncode@hotmail.com";

            //Assert de los que se esperan que sin problemas
            Assert.IsTrue(mailValidator.ValidateMail(mockEmail));
            Assert.IsTrue(mailValidator.ValidateMail(mockEmail2));
            Assert.IsTrue(mailValidator.ValidateMail(mockEmail3));
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
            Assert.IsFalse(mailValidator.ValidateMail(mockEmailFalse1));
            Assert.IsFalse(mailValidator.ValidateMail(mockEmailFalse2));
            Assert.IsFalse(mailValidator.ValidateMail(mockEmailFalse3));
        }

        
        // Hago el método un método aparte para comprobar si hay correos duplicados
        private bool HasDuplicates(List<string> correosValidados)
        {
            HashSet<string> set = new HashSet<string>(); // Uso el HashSet, una colección que no permite elementos duplicados.

            foreach (var mail in correosValidados)
            {
                if (!set.Add(mail))
                {
                    return true;
                }
            }
            return false;
        }

        [TestMethod]
        public void Return_False_When_Mail_Duplicated()
        {
            //Arrange
            var duplicatedMails = new List<string> { "jorge@gmail.com", "prueba@yahoo.com", "lemoncode@hotmail.com", "jorge@gmail.com" };
            var notDuplicatedMails = new List<string> { "jorge@gmail.com", "prueba@yahoo.com", "lemoncode@hotmail.com" };

            //Act
            var hasDuplicates1 = HasDuplicates(duplicatedMails);
            var hasDuplicates2 = HasDuplicates(notDuplicatedMails);

            // Assert
            Assert.IsTrue(hasDuplicates1);
            Assert.IsFalse(hasDuplicates2);
        }





    }
} 