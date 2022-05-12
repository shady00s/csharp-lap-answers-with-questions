using System;
using System.IO;

namespace DayFiveAnswers
{
    //question 5 bonus

    class Test : IFormattable
    {
        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }




    interface IPrintable
    {
        void Print();
       

    }


    /*
      
      Exercise 1
You developed a BankAccount class.
In this exercise, you will re-use this class and add a new instance method, called TransferFrom, which transfers money from a specified account into this one.
In the Main method, add code to create two BankAccount objects, each
having an initial balance of $100.
Add code to call TransferFrom and move $10 from one account to the
other.
Add code to display the current balances after the transfer.
Add Constructor chaining

     
     */
    class BankAccount
    {
        int accountOne;
        int accountTwo;
        int transferAmount;
        int accountID;
        public BankAccount( int AccountID ,int TransferAmount ,int AccountOne,int AccountTwo){
             
             accountID = AccountID;
            transferAmount = TransferAmount;
            accountOne = AccountOne;
            accountTwo = AccountTwo;
}
        public void TransferFrom()
        {
            int result = 0;
            int result2 = 0;
            if (accountID == 1)
            {
                result += (accountOne - transferAmount);
                result2 += (accountTwo + transferAmount);


                Console.WriteLine($"Transfeer {transferAmount}$ From account {accountOne} to account {accountTwo} ");
                Console.WriteLine($"account 1 Balance {result}");
                Console.WriteLine($"account 2 Balance {result2}");
            }
            else if (accountID == 2)
            {
                result += (accountTwo - transferAmount);
                result2 += (accountOne + transferAmount);


                Console.WriteLine("Transfeer 10$ From account 1 to account 2 ");
                Console.WriteLine($"account 1 Balance {result}");
                Console.WriteLine($"account 2 Balance {result2}");

            }
            else {
                Console.WriteLine($"No account with ID {accountID}");

            }

        }
    }
    /*
     Exercise 2
You developed an Utils class that contained a variety of utility methods.
In this exercise, you will add a new static method called Reverse to the Utils class. This method takes a string and returns a new string with the characters in reverse order




    
     */




    /*
     A class implements the System.IFormattable interface to return a string
representation of an instance of that class. Base types such as int and ulong
implement this interface (after the value has been boxed). Many reference types, for example string, do not. User-defined types can implement the interface if the developer requires it.

     */
    class Utils : IFormattable
    {

        public string Value { get; set; }


        public Utils( string val) {
            Value = val;
        }
        /*
         Exercise 5 : Bouns
Write a Display method that will use the as operator to determine whether the object passed as a parameter supports a user-defined interface called IPrintable and call a method of that interface if it is supported.
The starter code includes the definition for an interface called IPrintable,
which contains a method called Print. A class that implements this interface should use the Print method to display to the console the values held inside the object. Also defined in the starter code files is a class called Coordinate that implements the IPrintable interface.
A Coordinate object holds a pair of numbers that can define a position in
two-dimensional space. You do not need to understand how the Coordinate class works (although you might want to look at it). All you need to know is that it implements the IPrintable interface and that you can use the Print method to display its contents.


        Edit the Utils class as follows:
a. Add a public static void method called Display in the Utils class. This
method should take one parameter, an object passed by value, called
item.
b. In Display, declare an interface variable called ip of type IPrintable.
c. Convert the reference in the parameter item into a reference to the
IPrintable interface that uses the as operator. Store the result in ip.
d. If the value of ip is not null, use the IPrintable interface to call Print. If it is null, the object does not support the interface. In this case, use
Console.WriteLine to display to results of the ToString method on the
parameter instead.
Within the Main method in the Test class, create a variable of type int, a
variable of type string, and a variable of type Coordinate. To initialize the Coordinate variable, you can use the two-parameter constructor:
Coordinate c = new Coordinate(21.0, 68.0);
2. Pass these three variables, in turn, to Utils.Display to print them out

         */
        public static void Display(object Obj) { 
            
            
        }
        public static string Reverse( string value) {

            

            char[] val = value.ToCharArray();
            string result = String.Empty;

            for (int i = val.Length -1; i > -1; i--)
            {
                result += val[i];
            }
            return result;
        }

        /*
         Exercise 4 
Add a static method called IsItFormattable to the Utils class that you created before. The IsItFormattable method takes one parameter of type object and tests whether that parameter implements the System.IFormattable interface. If the object does have this interface, the method will return true. Otherwise, it will return false.
*/
        public static bool IsItFormattable(object obj) {
            if (obj is IFormattable)
            {
                return true;
            }
            else {
                return false;
            }
        }


        /*
         Exercise 3 : Bouns
In this exercise, you will write a program that prompts the user for the name of a text file.
    The program will check that the file exists, displaying a message and quitting if it does not.
    The file will be opened and copied to another file (prompt the user for the file name), but with every character converted to uppercase.
    Before you start, you might want to look briefly at the documentation for System.IO in the .NET Framework SDK Help documents. In particular, look at the documentation for the StreamReader and StreamWriter classes.

         */

        public static bool FileCreator(String fileName, string value) {
            if (File.Exists(fileName) ){

                Console.WriteLine("The file already exits exiting..");
                return false;

               
            }
            else {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(value);
                TextWriter oldWriter = Console.Out;


                sw.Close();
                fs.Close();

                Console.SetOut(oldWriter);
                return true;

            }
            
        }

        public static string FileReader(string fileName) {

            StreamReader sr = new StreamReader(fileName);
            string value = sr.ReadToEnd();

          return  value.ToUpper();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return Value;
        }

       
    }


   


    class Coordinate : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y) {

            X = x;
            Y = y;
        }
        public void Print()
        {
            Console.WriteLine($"The dimensions is X-axis = {X} ,Y-Axis = {Y}");
        }

    }
}
