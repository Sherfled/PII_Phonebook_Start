namespace Library
{
    public class Contact
    {
        public Contact(string name)
        {
            this.Name = name;
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