using System;
using System.Collections.Generic;
using Library;
using System.Linq;

/*
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contact5 = new Contact("Pedro", "095346278", "PEDRO@gmx.com");
            Phonebook owner = new Phonebook(contact5);
            

            // Crear la lista de contactos
            //List<Contact> contacts = new List<Contact>();

            Contact contact1 = new Contact("Juan", "099801925", "JUANITO@hotmail.com");
            Contact contact2 = new Contact("Mateo", "093489672", "MATEO@hotmail.com");
            Contact contact3 = new Contact("Belen", "091548712", "BELEN@hotmail.com");
            Contact contact4 = new Contact("Ana", "097586142", "ANA@hotmail.com")


            string[] names = new string[] {contact1.Name, contact2.Name, contact3.Name, contact4.Name};

            // Agregar contactos a la lista
            owner.Search(names);                         
            

            // Enviar un correo a algunos contactos
            owner.SendEmail(contact1, "Hola mundo");

            // Enviar un WhatsApp a algunos contactos
            owner.SendWPP(contact2, "Hola mundo");

            // Enviar un SMS a algunos contactos
            owner.SendWPP(contact3, "Hola mundo");  // Usamos la misma funcion, porque hace lo mismo.
        }
    }
}
*/


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
            List<Contact> contacts = new List<Contact>()
            {
                new Contact("Juan", "099801925", "JUANITO@hotmail.com"),
                new Contact("Mateo", "093489672", "MATEO@hotmail.com"),
                new Contact("Belen", "091548712", "BELEN@hotmail.com"),
                new Contact("Ana", "097586142", "ANA@hotmail.com")
            };

            //String[] listaString = new String[] {};
            List<string> listaString = new List<string>();

           
            // Agregar contactos a la libreta
            foreach (Contact contact in contacts)
            {
                phonebook1.Add(contact);
                listaString.Add(contact.Name); // agregar la información de cada contacto a la lista de strings
            }
            
            string[] lista = listaString.ToArray();
            
            
            // Buscar contactos por nombre
            phonebook1.Search(lista);
            

            // Enviar un correo a algunos contactos
            phonebook1.SendEmail(contacts[0], "Hola mundo");

            // Enviar un mensaje de texto a algunos contactos
            phonebook1.SendWPP(lista, contacts[2], "Hola mundo");

            // Enviar un SMS a algunos contactos
            phonebook1.SendSMS(lista, contacts[3], "Hola mundo");  
        }
    }
}