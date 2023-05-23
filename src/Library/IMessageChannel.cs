using System;
using System.Collections.Generic;

namespace Library
{
    public interface IMessageChannel
    {
        void SendWPP(Contact contact, string text);
        void SendEmail(Contact contact, string text);
    }
}