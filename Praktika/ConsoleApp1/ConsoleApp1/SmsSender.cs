using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SmsSender:MessageSender
    {

        public override void SendMessage()
        {
            Console.WriteLine("2   Send message by sms");
        }
    }
}
