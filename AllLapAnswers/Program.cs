using System;

namespace AllLapAnswers
{
    class Program
    {
      
        static void Main(string[] args)
        {

            DaySevenAnswers.Rational x = new DaySevenAnswers.Rational(6,8);
            DaySevenAnswers.Rational y = new DaySevenAnswers.Rational(1,2);


            var w = x++;
            Console.WriteLine(y++);


            //Console.WriteLine(z.Equals(x));
         

            //DayFiveAnswers.BankAccount df = new DayFiveAnswers.BankAccount(1, 1200, 45300, 3200);


            //df.TransferFrom();

            //DaySixAnswers.BankAccount a = new DaySixAnswers.BankAccount(12);

            //a.Deposit();

            //DaySevenAnswers.BankAccount x = new DaySevenAnswers.BankAccount(20);
            //DaySevenAnswers.BankAccount y = new DaySevenAnswers.BankAccount(21);

            //DaySevenAnswers.BankAccount yu = new DaySevenAnswers.BankAccount();

            //DayThreeAnswers.ArrayProblems c = new DayThreeAnswers.ArrayProblems();

            //Console.WriteLine(yu.Equals(c));

            //if (x != y)
            //    Console.WriteLine("Sa7");
            //else
            //    Console.WriteLine("la");

        }
    }
}
