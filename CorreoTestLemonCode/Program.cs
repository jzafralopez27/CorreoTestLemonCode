using CorreoTestLemonCode;

var validator = new EmailValidator();
List<string> correosValidados = new List<string>();
string mail;

do
{
    Console.WriteLine("Introduce tu correo");
    mail = Console.ReadLine();

    bool validMail = validator.ValidateMail(mail);

    if (validMail)
    {
        Console.WriteLine("Valid email");
        correosValidados.Add(mail);
    }
        


    else
    {
        Console.WriteLine("NOT a valid email");
    }
} while (mail != "quit");
