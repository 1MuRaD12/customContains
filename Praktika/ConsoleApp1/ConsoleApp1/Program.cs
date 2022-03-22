using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1   Send message by email");
            Console.WriteLine("2   Send message by sms");
            Console.WriteLine("0   Quit");

            EmailSender emailSender = new EmailSender();
            SmsSender smsSender = new SmsSender();


            #region Switch
            //int Number = Convert.ToInt32(Console.ReadLine());

            //switch (Number)
            //{
            //    case 1:
            //        emailSender.SendMessage();
            //        break;
            //    case 2:
            //        smsSender.SendMessage();
            //        break;
            //    case 0:
            //        Console.WriteLine("Finish");
            //        break;
            //    default:
            //        Console.WriteLine("Duzgun daxil edin");
            //        break;
            //}
            #endregion




            #region Do While
            //int Number = 0;
            //do
            //{
            //    Number = Convert.ToInt32(Console.ReadLine());

            //    emailSender.SendMessage();


            //    smsSender.SendMessage();


            //    Console.WriteLine("0   Finish");



            //}while (Number !=0);
            #endregion

        }
    }
}
