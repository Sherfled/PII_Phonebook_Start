using System;
using System.Collections.Generic;

namespace Library
{
    public interface IMessageChannel
    {
        void SendSMS(string[] myNames, Contact contact, string text);
        void SendWPP(string[] myNames, Contact contact, string text);
        void SendEmail(Contact contact, string text);
    }
}