namespace CorreoTestLemonCode
{
    public class EmailValidator
    {
        public const string correoValido = "El correo electrónico es valido";
        public const string correoErroneo = "El correo electrónico no es valido";
        

        public bool ValidateMail(string mail)
        {
            string extension1 = "@gmail.com";
            string extension2 = "@yahoo.com";
            string extension3 = "@hotmail.com";

            return mail.Contains(extension1) || mail.Contains(extension2) || mail.Contains(extension3);

        }
    }
}
