using System;
using System.Collections.Generic;


namespace Library
{
    public class Phonebook : IMessageChannel
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }


        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
     

        public void Add(Contact contact)
        {
            this.persons.Add(contact);
        }
        


        public void Remove(Contact contact)
        {
            this.persons.Remove(contact);
        }


        // Creo que habria que hacerle una clase para este y para el Mail, pero no se como hacer para llevar la lista "Persons".
        public void SendWPP(Contact contact, string text)
        {
            //List<Contact> persons = this.Search(myNames);
            int send = 0;
            if (contact.Name != this.Owner.Name)
            {
                foreach (Contact person in persons)
                {
                                    
                    if (person.Name == contact.Name)
                    {
                        Message myMessage = new Message(this.Owner.Name, person.Name);
                        myMessage.Text = text;
                        person.Recive(myMessage.From, myMessage);
                        Console.WriteLine("Su mensaje ha sido enviado con exito.");
                        send++;
                    }
                }
            }
            else
            {
                Console.WriteLine("No puede enviarse mensaje de texto a usted.");
            }

            if (send == 0)
            {
                Console.WriteLine($"Usted no tiene al contacto {contact.Name} entre sus contactos.");
            }

        }

        public void SendEmail(Contact contact, string text)
        {
            int sendE = 0;
            if (contact.Email == this.Owner.Email)
            {
                Console.WriteLine("No puede enviar emails a usted.");
            }
            else
            {
                foreach (Contact person in persons)
                {
                                    
                    if (person.Email == contact.Email)
                    {
                        Message myMessage = new Message(this.Owner.Name, person.Name);
                        myMessage.Text = text;
                        person.Recive(myMessage.From, myMessage);
                        Console.WriteLine("Su mensaje ha sido enviado con exito.");
                        sendE++;
                    }
                }
            }

            if (sendE == 0)
            {
                Console.WriteLine($"No tiene el email de {contact}.");
            }  
        
        
        
        
        }
    }
}