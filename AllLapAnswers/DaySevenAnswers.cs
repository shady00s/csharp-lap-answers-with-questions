using System;
using System.Collections;

namespace DaySevenAnswers
{
    /*
        1 – 
You will define the == and != operators in the Bank Account
class. The default implementation of these operators, which is inherited from Object, tests to check whether the references are the same. You will redefine them to examine and compare the information in two accounts.

2- 
Override the Equals and ToString methods.
3- 
Create an entirely new class for handling rational numbers. This is a brief respite from the world of banking. A rational number is a number that can be written as a ratio of two integers. (Examples of rational numbers include ½, ¾, and -17.) You will create a Rational class, which will consist of a pair of private integer instance variables (called dividend and divisor) and operators for performing calculations and comparisons on them. The following operators and methods will be defined:
 A - Rational (int dividend)
This is a constructor that sets the dividend to the supplied value and the
divisor to 1.
B - Rational (int dividend, int divisor)
This is a constructor that sets the dividend and the divisor.
C - == and! =
These will perform comparisons based upon the calculated numeric value of the two operands (for example, Rational (6, 8) == Rational (3, 4)).
You must override the Equals ( ) methods to perform the same comparison.
n <, >, <=, >=
These will perform the appropriate relational comparisons between two
rational numbers (for example, Rational (6, 8) > Rational (1, 2)).
D - Binary + and –
These will add one rational number to or subtract one rational number from
another.
E - ++ and --
These will increment and decrement the rational number.

     */
    class BankAccount
    {

        private DaySixAnswers.AccountType AccountType;

        private decimal AccountNumber;

        private decimal AccountBalance;


        public override string ToString()
        {

            return "It must work wlahy";
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Fady");
                return false;
            }
            else if (!(obj is BankAccount))
            {
                Console.WriteLine("la msh BankAccount");
                return false;
            }
            else
                Console.WriteLine("Gada3");
            return true;
        }
        public decimal accBalance()
        {

            return AccountBalance;
        }

        private decimal numberGenrator()
        {
            Random rand = new Random();
            decimal result = 0;

            result += rand.Next(1, 9999);

            return result;

        }

        public BankAccount() { }
        public BankAccount(int accountType) { AccountNumber = numberGenrator(); AccountType = (DaySixAnswers.AccountType)accountType; AccountBalance = 0; }
        public BankAccount(decimal accountBalance) { AccountNumber = numberGenrator(); AccountType = DaySixAnswers.AccountType.Checking; AccountBalance = accountBalance; }
        public BankAccount(int accountType, decimal accountBalance) { AccountNumber = numberGenrator(); AccountType = (DaySixAnswers.AccountType)accountType; AccountBalance = accountBalance; }


        public decimal Deposit()
        {
            Queue queue = new Queue();
            DaySixAnswers.BankTransaction BT = new DaySixAnswers.BankTransaction(212222);

            decimal FromBT = BT.valueAmount();
            DateTime DTFromBT = BT.CurrentDate();

            decimal result = FromBT + AccountBalance;

            Console.WriteLine($"The account after deposit is {result}");

            queue.Enqueue("Deposit on account " + AccountNumber + " is " + result + " at date " + DTFromBT.ToString());

            return result;

        }

        public decimal WithDraw()
        {
            Queue queue = new Queue();
            DaySixAnswers.BankTransaction BT = new DaySixAnswers.BankTransaction(212222);

            decimal FromBA = BT.valueAmount();
            DateTime DTFromBT = BT.CurrentDate();

            decimal result = 0;
            if (FromBA < AccountBalance)
            {

                Console.WriteLine("There will be 0$ cash,  do you wish to continue? ");
                return result += -1;

            }
            else if (FromBA == AccountBalance)
            {

                Console.WriteLine("There will be 0$ cash,  do you wish to continue? ");
                return result += -1;


            }
            else
            {



                result += FromBA - AccountBalance;
                Console.WriteLine($"The account after withdraw is {result}");

                queue.Enqueue("Withdraw on account " + AccountNumber + " is " + result + " at date " + DTFromBT.ToString());
                return result;

            }

        }

        public static bool  operator == (BankAccount a, BankAccount b) {

            if (a.AccountType == b.AccountType)
                return true;
            else
                return false;


        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {

            if (a.AccountType != b.AccountType)
                return true;
            else
                return false;


        }


        public override int GetHashCode()
        {
            return (int)AccountType;
        }

        ~BankAccount()
        {
            Queue queue = new Queue();


            foreach (Queue item in queue)
            {
                Console.WriteLine(item);
            }
           
        }

       
    }   

    class Rational {
        private readonly int Dividend;
        private readonly int Divisor;
       

        public Rational(int dividend) { Dividend = dividend; Divisor = 1; }
        public Rational(int dividend, int divisor) { Dividend = dividend; Divisor = divisor; }


        
        public static bool DivideResult(int a , int b) {
            int AModulus= a % b;
            int BModulus = b % a;

            if (AModulus ==0 && BModulus ==0 )
            {
                return true;
            }
            else if (AModulus > 0 || BModulus  > 0) {

                if (AModulus  == BModulus ) {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static bool operator ==(Rational a, Rational b) {

            if (DivideResult(a.Dividend, a.Divisor) && DivideResult(b.Dividend, b.Divisor)) {
                return true;

            }
            else if (a.Dividend == b.Dividend && a.Divisor == b.Divisor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Rational a, Rational b) {

            if (a.Dividend != b.Dividend && a.Divisor != b.Divisor && DivideResult(a.Dividend, a.Divisor) && DivideResult(b.Dividend, b.Divisor))
                return true;
            else
                return false;

        }

        public override bool Equals(object obj)
        {
           
            if (DivideResult(((Rational)obj).Dividend, ((Rational)obj).Divisor) && DivideResult(this.Dividend, this.Divisor)|| ((Rational)obj).Dividend == this.Dividend && ((Rational)obj).Divisor == this.Divisor)
            {
                return true;
            }

            else if (ReferenceEquals(obj, null))
            {
                return false;
            }
            else {

                return false;
            }
            
        }

        public override int GetHashCode()
        {
            //  return Tuple.Create(Dividend, Divisor).GetHashCode();
            return Dividend ^ Divisor;
        }


        public static bool operator <(Rational a, Rational b) {
            if ((a.Dividend * b.Divisor) < (b.Dividend * a.Divisor))
                return true;

            return false;
        
        }


        public static bool operator >(Rational a, Rational b)
        {
            if ((a.Dividend * b.Divisor) > (b.Dividend * a.Divisor))
                return true;
            return false;

        }



        public static bool operator <=(Rational a, Rational b)
        {
            if ((a.Dividend * b.Divisor) <= (b.Dividend * a.Divisor))
                return true;

            return false;

        }

        public static bool operator >=(Rational a, Rational b)
        {
            if ((a.Dividend * b.Divisor) >= (b.Dividend * a.Divisor))
                return true;

            return false;

        }
            
        public static Rational operator + (Rational a, Rational b)
        {

            int x = (a.Dividend * b.Divisor) + (b.Dividend * a.Divisor);

            int y = a.Divisor * b.Divisor;
            return new Rational(x ,y );
            
        }

        public static Rational operator - (Rational a, Rational b)
        {

            Rational result = new Rational((a.Dividend * b.Divisor) - (a.Divisor * b.Dividend), a.Divisor * b.Divisor);
            return result;

        }

        public static Rational operator ++(Rational a)
        {
            return new Rational( (a.Dividend / a.Divisor) + 1);

        }

        public static Rational operator --(Rational a)
        {

            Rational result = new Rational(1-(a.Dividend / a.Divisor)  );
            return result;

        }
        public override string ToString()
        {
            return $"{Dividend}/{Divisor}"; 
        }


    }
}
