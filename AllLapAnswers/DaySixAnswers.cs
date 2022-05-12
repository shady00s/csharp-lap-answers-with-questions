using System;
using System.Collections;

namespace DaySixAnswers

{


    enum AccountType : int { 
        
        Checking = 1,
        Deposit = 2
    
    }



    /*
     Exercise 1
You will modify the BankAccount class that you created in the previous labs. You will remove the methods that populate the account number and account type instance variables and replace them with a series of constructors that can be used when a BankAccount is instantiated. You will override the default constructor to generate an account number (by using the technique that you used earlier), set the account type to Checking, and set the balance to zero.
You will also create three more constructors that take different combinations of
parameters: 
- The first will take an AccountType. The constructor will generate an
account number, set the balance to zero, and set the account type to the
value passed in.
- The second will take a decimal. The constructor will generate an account
number, set the account type to Checking, and set the balance to the value
passed in.
- The third will take an AccountType and a decimal. The constructor will
generate an account number, set the account type to the value of the
AccountType parameter, and set the balance to the value of the decimal
parameter.


     */
    class BankAccount {

        private AccountType AccountType;

        private decimal AccountNumber;

        private decimal AccountBalance;

        public decimal accBalance() {

            return AccountBalance;
        } 

        private decimal numberGenrator() {
            Random rand = new Random();
            decimal result = 0;

            result += rand.Next(1,9999);

            return result;

        }


        public BankAccount(int accountType) { AccountNumber = numberGenrator(); AccountType = (AccountType)accountType; AccountBalance = 0; }
        public BankAccount(decimal accountBalance) { AccountNumber = numberGenrator(); AccountType = AccountType.Checking;  AccountBalance = accountBalance; }
        public BankAccount( int accountType ,decimal accountBalance) { AccountNumber = numberGenrator(); AccountType = (AccountType)accountType;AccountBalance = accountBalance; }


        public decimal Deposit()
        {
            Queue queue = new Queue();
            BankTransaction BT = new BankTransaction( 212222);

            decimal FromBT = BT.valueAmount();
            DateTime DTFromBT = BT.CurrentDate();

            decimal result = FromBT + AccountBalance;

            Console.WriteLine($"The account after deposit is {result}");

            queue.Enqueue("Deposit on account "+AccountNumber+" is "+result + " at date "+DTFromBT.ToString());

            return result;

        }

        public decimal WithDraw()
        {
            Queue queue = new Queue();
            BankTransaction BT = new BankTransaction(212222);

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


        /*
         Exercise 4: Bouns
Use the Disposal design pattern to ensure that a BankTransaction’s data is saved on demand rather than when garbage collection destroys the BankTransaction. You will also need to inform garbage collection that the BankTransaction has already been disposed of and suppress any attempt by garbage collection to destroy it again later. You will add a Dispose method to the BankAccount and BankTransaction
classes. The Dispose method in BankAccount will iterate through all of the
transactions in its transaction queue, and call Dispose for each transaction

         */
        ~BankAccount()
        {
            Queue queue = new Queue();


            foreach (Queue item in queue)
            {
                Console.WriteLine(item);
            }
            //add file streams from the previous code 
              // DayFiveAnswers.Utils.FileCreator("DaySixValue.txt",queue );
        }

    }
    /*
     Exercise 2
You will create a new class called BankTransaction. It will hold information about a deposit or withdrawal transaction that is performed on
an account. Whenever the balance of an account is changed by means of the Deposit or Withdraw method, a new BankTransaction object will be created. The
BankTransaction object will contain the current date and time (generated from
System.DateTime) and the amount added (positive) or deducted (negative) from the account. Because transaction data cannot be changed once it is created, this information will be stored in two readonly instance variables in the
BankTransaction object.
The constructor for BankTransaction will take a single decimal parameter,
which it will use to populate the transaction amount instance variable. The date
and time instance variable will be populated by DateTime.Now, a property of
System.DateTime that returns the current date and time.
You will modify the BankAccount class to create transactions in the Deposit
and Withdraw methods. You will store the transactions in an instance variable
in the BankAccount class of type System.Collections.Queue. A queue is a
data structure that holds an ordered list of objects. It provides methods for
adding elements to the queue and for iterating through the queue. (Using a
queue is better than using an array because a queue does not have a fixed size: it
will grow automatically as more transactions are added.)

     */
    class BankTransaction
    {
        private readonly DateTime currentDate = DateTime.Now;
        private readonly decimal ValueAdded ;

        public BankTransaction(int valueAmount) { ValueAdded = valueAmount; }


        public decimal valueAmount (){ return ValueAdded; }
        public DateTime CurrentDate() { return currentDate; }

    }



    //assignment 2
    // ex2 bonus 2 
    /*
     1. Create a class called Widget that declares two public methods. 
    Create both methods so that they return void and so that they do not use parameters.
    Call the first method First, and declare it as virtual. Call the second method Second,
    and do not declare it as virtual. Create a class called FancyWidget that extends Widget,
    overriding the inherited First method and hiding the inherited Second method.


    2. Bouns 
Create an interface called IWidget that declares two methods. Create both methods so that they return void and so that they do not use parameters. Call the first method First, and call the second method Second. Create a class called Widget that implements IWidget. Implement First as virtual, and implement Second explicitly.

3. Create an abstract class called Widget that declares a protected abstract
method called First that returns void and does not use parameters. Create a
class called FancyWidget that extends Widget, overriding the inherited
First method.
4. Bouns
Create a sealed class called Widget that implements the IWidget interface that you created in question 2. Create Widget so that it implements both inherited methods explicitly

     */

    class Widget :IWidget {

        public virtual void First() { 
        
        
        }
        public void Second() { 
        
        }
    }


    class FancyWidegt : Widget{
        public  new void First() { }

        public new void Second() { }
    
    }


    // ex bonus 3 

    interface IWidget
    {
        void First();
        void Second();

    }
    abstract class Widgets  {

        protected virtual void First() { 
        
}

        protected void Second() {
        
        }


    }

    class FancyWidget2 : Widgets {

        public new virtual void First() { }
    }

    sealed class Widgetss : IWidget
    {
        public void First()
        {
            throw new NotImplementedException();
        }

        public void Second()
        {
            throw new NotImplementedException();
        }
    }

}
