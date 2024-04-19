Ejercicio 1


Creo la clase EmailValidator, en la cual configuro las condiciones para que se considere un mail válido. Creo que hay una función propia para que C# lo considere un correo o no, pero he querido hacerlo así.

![Ej1Test1](https://github.com/jzafralopez27/CorreoTestLemonCode/assets/149962801/2c0e416a-9eff-41e3-91a9-8a7ed730ea8d)

En el ejecutable, el Program.cs, añado el bucle para que me siga pidiendo un correo hasta que escriba 'quit'.

![Ej1Main](https://github.com/jzafralopez27/CorreoTestLemonCode/assets/149962801/3ded5606-6a4f-4bfd-8e83-fe5947a86834)

Y en la clase CorreoMessageShould implemento la lógica de los Test, uno que me diga ok si los correos contienen la extensión dada en EmailValidator y por lo tanto son válidos, y otra justo lo contrario.
Ámbos métodos los separo con sus correspondientes [TestMethod].

![Ej1Test1](https://github.com/jzafralopez27/CorreoTestLemonCode/assets/149962801/39f6b88d-67fd-4efb-9465-64f00bb4e71d)

Y ahora podemos comprobar que ámbos tests dan Ok, unos emails son válidos y otros no.

![TestOk](https://github.com/jzafralopez27/CorreoTestLemonCode/assets/149962801/83f8b5f5-37ca-44bd-977e-24dc2c3b0e0d)

Ejercicio 2

Pues básicamente le añado dos métodos más a la clase CorreoMessageShould, uno que me comprueba si hay correos duplicados y otra que me hace realmente el Test, con su Arrange, Act y Assert. 
![Captura de pantalla 2024-04-19 114322](https://github.com/jzafralopez27/CorreoTestLemonCode/assets/149962801/fd143043-949f-4335-8c1f-bd3c5bd71ec8)

Y ahora comprobamos que los 3 tests nos dan Ok.
![Captura de pantalla 2024-04-19 114552](https://github.com/jzafralopez27/CorreoTestLemonCode/assets/149962801/366a55e3-cbe3-4a8a-94e4-f0a6aa3fdd92)
