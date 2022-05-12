using System;


namespace DayTwo
{

    enum Bank_acc_types : byte

    {
        checking = 1,
        saving = 2,
        deposit = 3
    }




    class DayTwoAnswers
    {
        #region Exercise 1
        /*Exercise 1
         * Create an enumerated type for representing different
            types of bank accounts (checking and savings). You will create two variables by using this enum type, and set the values of the variables to Checking and savings. You will then print the values of the variables by using the System.Console.WriteLine function

         */
        public static void Ex1()
        {

            try
            {

                Bank_acc_types checks = Bank_acc_types.checking;
                Bank_acc_types deposits = Bank_acc_types.deposit;
                Console.WriteLine("Bank Accounts Types:\n \n  1-checking account \n  2-Saving account \n  3-deposit");
                Console.Write("Please select bank account type:");
                Bank_acc_types val1 = (Bank_acc_types)int.Parse(Console.ReadLine());

                switch (val1)
                {
                    case Bank_acc_types.checking:
                        Console.WriteLine($"You choosed {checks}");

                        break;
                    case Bank_acc_types.deposit:
                        Console.WriteLine($"You choosed {deposits}");


                        break;
                    default:
                        break;
                }


            }
            catch (Exception err)
            {

                Console.WriteLine(err);
            }


        }



        #region Exercise 2
        //Exercise 2 
        /*
         Define a struct that can be used to +a bank
         account. You will use variables to hold the account number (a long), the account balance (a decimal), and the account type (the enum that you created in Exercise 1). You will create a struct type variable, populate the struct with
         some sample data, and print the result.




        Exercise 3 

        You will modify the code written in Exercise 2. You will prompt the user to enter the account number, type and balance. You will use these data to print the account summary.

         */


        struct Bank_acc_info
        {
            public long acc_number;
            public decimal acc_balance;
            public Bank_acc_types bankTypes;


        }
        public static void Ex2()
        {
            Bank_acc_info customerInfo;
            try
            {
                Console.Write("account ID:");
                long val1 = long.Parse(Console.ReadLine());
                customerInfo.acc_number = val1;

                Console.Write("Balance:");
                decimal val2 = decimal.Parse(Console.ReadLine());

                customerInfo.acc_balance = val2;

                Console.Write("Account Type:");
                byte val3 = byte.Parse(Console.ReadLine());
                customerInfo.bankTypes = (Bank_acc_types)val3;


                Console.WriteLine($" Account ID :{val1}, \n Account Balance:{val2}, \n Account Type:{customerInfo.bankTypes}");

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

        }
        #endregion
    }
}
