using CorreoTestLemonCode;

var validator = new EmailValidator();

string mail;

do
{
    Console.WriteLine("Introduce tu correo");
    mail = Console.ReadLine();

    bool validMail = validator.ValidarCorreo(mail);

    if (validMail)
        Console.WriteLine("Valid email");
    else
    {
        Console.WriteLine("NOT a valid email");
    }
} while (mail != "quit");
