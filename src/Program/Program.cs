using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contact5 = new Contact("Pedro", "095346278", "PEDRO@gmx.com");
            Phonebook phonebook1 = new Phonebook(contact5);
            

            // Crear la lista de contactos
            List<String> contacts = new List<String>();

            Contact contact1 = new Contact("Juan", "099801925", "JUANITO@hotmail.com");
            Contact contact2 = new Contact("Mateo", "093489672", "MATEO@hotmail.com");
            Contact contact3 = new Contact("Belen", "091548712", "BELEN@hotmail.com");
            Contact contact4 = new Contact("Ana", "097586142", "ANA@hotmail.com");


            string[] names = new string[] {contact1.Name, contact2.Name, contact3.Name, contact4.Name};

            // Agregar contactos a la lista
            phonebook1.Search(names);                         
            

            // Enviar un correo a algunos contactos
            phonebook1.SendEmail(contact1, "Hola mundo");

            // Enviar un WhatsApp a algunos contactos
            phonebook1.SendWPP(contact2, "Hola mundo");

            // Enviar un SMS a algunos contactos
            phonebook1.SendWPP(contact3, "Hola mundo");  // Usamos la misma funcion, porque hace lo mismo.
        }
    }
}
