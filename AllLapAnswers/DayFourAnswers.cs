 using System;


namespace DayFourAns
{


    /*
        Exercise 1
Create the bank account as a class. You will declare its data members as private but provide non-static public methods for accessing the data. You will build a test harness that creates an account object and populates it with an account number and balance that is specified by the user. Finally, you will print the data in the account.
        Exercise 2
Modify the BankAccount class from Exercise 1 so that it will generate unique account numbers. You will accomplish this by using a static variable in the BankAccount class and a method that increments and
returns the value of this variable. When the test harness creates a new account, it will call this method to generate the account number. It will then call the method of the BankAccount class that sets the number for the account, passing in this value as a parameter.

    */
    class BankAccount { 
    

        private int account_number;
        private int account_balance;
        private string username;
        
       
        public int Account_number
        {
            get { return account_number; }
            set { account_number = value; }
        }
        public int Account_balance {

            get { return account_balance; }
            set { account_balance = value; }
        }
        public string userName
        {
            get { return username; }
            set { username = value; }
        }

}
    /*
        Exercise 3
Add three methods to the Account class: TryWithdraw, TryDeposit and Welcome.
TryWithdraw will take a decimal parameter and will deduct the given amount from the balance. However, it will check first to ensure that sufficient funds are available, since accounts are not allowed to become overdrawn. It will return a bool value indicating whether the withdrawal was successful.
TryDeposit will also take a decimal parameter whose value it will add to the balance in the account. It will return the new value of the balance.
Welcome method it take name and return string with hello “name” if name not equal null.

     */
    class Account {
    
           
  
        public static void TryWithDraw(){
            
            
            BankAccount ba = new BankAccount();
            Console.WriteLine("WithDraw value: ");
            int amountFromUser = int.Parse(Console.ReadLine());
            int val = ba.Account_balance;
            int added = val + numberGenerator();

            if (amountFromUser > added)
            {

                Console.WriteLine("There is not enough cash");
            }
           
                
               int  result = added - amountFromUser;
            
            Console.WriteLine($"Your balance before Withdraw: {added}");
            Console.WriteLine($"Your balance after Withdraw: {result}");
        }

        public static void TryDeposit() {
            BankAccount ba = new BankAccount();
            int acc = ba.Account_balance;
            int val = acc + numberGenerator();
            Console.Write("Deposit value:  ");

            int amountFromUser = int.Parse(Console.ReadLine());

            

            Console.WriteLine($"Before deposit:  {val}");


            int result = val + amountFromUser;


            Console.WriteLine($"After deposit: {result} ");


        }

        private static int numberGenerator()
        {
            Random rand = new Random();

            return rand.Next(9999);

        }


        public static void Welcome() {


            BankAccount ba = new BankAccount();
            Console.WriteLine(" please enter your name:  ");
           string name1 =  Console.ReadLine();
          string result =  ba.userName = name1;
            if (string.IsNullOrWhiteSpace(name1))
            {
                Console.WriteLine("No name Enterd.");
                Welcome();
            }

            else {
               

                Console.WriteLine($"Welcome {result}");



            }

           
        }
    
    }
}
