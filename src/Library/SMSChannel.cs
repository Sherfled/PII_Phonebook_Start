using System;
using System.Collections.Generic;

namespace Library
{
    public class WPPChannel 
    {
        
        public void SendWPP(string[] myName, string text)
        {
            
            List<Contact> persons = this.Search(myName);

            foreach (Contact person in persons)
            {
                //foreach (string name in myNames)
                //{
                    if (person.Name.Equals(myName))
                    {
                        Message myMessage = new Message(PhoneBook.Owner.Name, person.Name);
                        myMessage.Text = text;
                        person.Recive(myMessage.From, myMessage);
                    }
                //}
            }
            
        }
    }
}