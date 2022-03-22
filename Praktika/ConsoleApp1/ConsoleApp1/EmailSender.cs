using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("1   Send message by email"); 
        }

    }
}
