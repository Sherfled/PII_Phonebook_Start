using System.Collections.Generic;

namespace Library
{
    public class Phonebook //: IMessageChannel
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

        public void Add(string name, string phone, string email)
        {
            this.persons.Add(new Contact(name));
        }

        public void Remove(Contact contact)
        {
            this.persons.Remove(contact);
        }


        // Creo que habria que hacerle una clase para este y para el Mail, pero no se como hacer para llevar la lista "Persons".
        public void SendSMS(string myName, string text)
        {
            //List<Contact> persons = this.Search(myNames);
            int send = 0;
            foreach (Contact person in persons)
            {
                                
                if (person.Name == myName)
                {
                    Message myMessage = new Message(this.Owner.Name, person.Name);
                    myMessage.Text = text;
                    person.Recive(myMessage.From, myMessage);
                    send++;
                }
            }
            if (send == 0)
            {
                Console.WriteLine($"Usted no tiene al contacto {myName} entre sus contactos.");
            }

        }

        public void SendEmail(Contact contact, string text)
        {
            if (contact.Name == this.Owner.Name)
            {
                Console.WriteLine("No puede enviar emails a usted.");
            }
            else
            {
                Message myMessage = new Message(this.Owner.Name, contact.Name);
                myMessage.Text = text;
                contact.Recive(myMessage.From, myMessage);
            
        }
    }
}