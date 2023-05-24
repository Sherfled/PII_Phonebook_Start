using System;
using System.Collections.Generic;

namespace Library
{
    public class Contact
    {
        public Contact(string name , string phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Recive(string name, Message text)
        {
            return $"{name}: {text}";
        }

        public string Email { get; set; }
    }
}