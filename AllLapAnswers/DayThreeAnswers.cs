 using System;
using System.IO;


namespace DayThreeAnswers
{

    #region Exercise 1

    /*
     
     Exercise 1
Create a class called Utils. In this class, you will create a method
called Greater. This method will take two integer parameters as input and will
return the value of the greater of the two.
To test the class, you will create another class called Test that prompts the user
for two numbers, and then calls Utils.Greater to determine which number is the
greater of the two, and then prints the result.

     */
    class Utils
    {
        public static int Greater(int x , int y) {
            int result = 0;
            try
            {
                if (x > y)
                {

                    result += x;
                }
                else if (x < y)
                {
                    result += y;

                }
            }
            catch (Exception err) {
                Console.WriteLine(err);
            }

            return result;
        
        }

        public static void Test(int result) {
            
            Console.WriteLine($"the number is {result}");
      
        }
    }

    #endregion



    class MethodsAndParams {


        /*
         Exercise 2
            Write a method called Swap that will exchange the values of its parameters. You will use parameters that are passed by reference.

         */
        public static int Swap(ref int testNumber) {
            return testNumber + 5;

        }


        /*
         
         Exercise 3
            Write a new method called Factorial that takes an int value and
            calculates its factorial. The factorial of a number is the product of all the
            numbers between 1 and that number. The factorial of zero is defined to be 1.
            The following are examples of factorials:
            -  Factorial(0) = 1
            -  Factorial(1) = 1
            -  Factorial(2) = 1 * 2 = 2
            -  Factorial(3) = 1 * 2 * 3 = 6
            -  Factorial(4) = 1 * 2 * 3 * 4 = 24
            Exercise 4 : Bouns
            Re-implement the Factorial method that you created in Exercise 3 by using recursion rather than a loop. The factorial of a number can be defined recursively as follows: 
            The factorial of zero is 1, and you can find the factorial of any larger integer by multiplying that integer with the factorial of the previous number. In summary:
            If n=0, then Factorial(n) = 1; otherwise it is n * Factorial(n-1)

         */
        public static int Factorial(int value)
        {
            int result = 1 ;

            for (int i = 1; i <= value; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static int FactorialBonus(int value)
        {
            int result = 0;
            if (value == 0) {
                result =  1;

            }
            else {
                result = value * FactorialBonus(value - 1);
            }
            return result;
        }
    }


    class ArrayProblems
    {

        /*
         Exercise 1 : Bouns
            write a program that expects the name of a text file as an argument to Main. The program will summarize the contents of the text file. It will read the contents of the text file into an array of characters and then iterate through the array, counting the number of vowels and consonants. Finally, it will print the total number of characters, vowels, consonants, and newlines to the console.

         */


        public static void ExBonus(string fileName, string content) {
            // create file 
         
                FileCreator(fileName,content);

            //read From the new file 
    
                string valueFromFile = FileReader(fileName);
            Console.WriteLine($"Text from file: \n {valueFromFile}");

            // to get the number of vowls
            char[] charVal = valueFromFile.ToCharArray();
            int vouwlVal = 0;
            int consonantsVal = 0;

            for (int i = 1; i < charVal.Length; i++)
            {
                if (charVal[i] == 'a' || charVal[i] == 'e' || charVal[i] == 'i' || charVal[i] == 'o' || charVal[i] == 'u' || charVal[i] == 'y' || charVal[i] == 'w') {
                    vouwlVal++;
                }
                else
                {
                    consonantsVal++;

                }
            }

            Console.WriteLine($"The number of vouwls is {vouwlVal} \n consanant number {consonantsVal}");


        }

        public static void FileCreator(string fileName ,string content)
        {
            // create the file 
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(content);
                TextWriter oldWriter = Console.Out;


                sw.Close();
                fs.Close();
                Console.SetOut(oldWriter);
            }
            catch (Exception err) {

                Console.WriteLine(err);
            }
        }

        public static string  FileReader(string fileName) {

            string result = "";
           try { 
            StreamReader sr = new StreamReader(fileName);
            String readFromFile = sr.ReadLine();
            result = readFromFile;

            }
            catch (Exception err)
            {
                Console.WriteLine(err);

            }
            return result;
        }

        /*
         
         Exercise 2
            Write a program that uses arrays to multiply matrices together. The program will read four integer values from the console and store them in a 2 x 2 integer matrix. It will then read another four integer values from the console and store them in a second 2 x 2 integer matrix. The program will then multiply the two matrices together, storing the result in a third 2 x 2 integer matrix. Finally, it will print the resulting matrix to the console.

         */
        public static void  Exercise2() {
            // the array with 2 dimentions 

            int row = 2;
            int col = 2;
            int[,] array1 = new int[row, col];
            int[,] array2 = new int[row, col];
            int[,] result = new int[row, col];

            
            // loop through on the first array
            Console.WriteLine("First Matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // loop through the sec loop

            Console.Write("sec matrix: ");
            for ( int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // loop inside the two arrays to get the value and  insert it inside the result matrix

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < 2; k++)
                    {
                       result[i, j] += array1[i, k] * array2[k, j];
                    }
                }
            }

            // print the result matrix

            Console.WriteLine("The final result: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }




        /*
         1. Declare an array of ints of rank 1 called evens, and initialize it with the first
            five even numbers, starting with zero.
            2. Write a statement that declares variable called crowd of type int, and
            initialize it with the second element of evens. Remember, the second
            element does not reside at index 2 because array indexes do not start at 1.
            3. Write two statements. The first will declare an array of ints of rank 1 called
            copy; the second will assign to copy from evens.
            4. Write a static method called Method that returns an array of ints of rank 2
            and expects no arguments. The body of Method will contain a single return
            statement. This statement returns a newly created array of rank 2 with
            dimensions 3 and 5 whose 15 elements are all initialized to 42.
            5. Write a static method called Parameter that returns nothing and expects a
            two-dimensional array as its single argument. The body of the method will
            contain two WriteLine statements that write the length of each dimension
            to the console.
            6. Write a foreach statement that iterates over a one-dimensional array of
            strings called names, writing each name to the console.

         */
        public static void Exercise3()
        {
            //q1
            int[] evens = new int[5] { 0, 2, 4, 6, 8 };

            //q2 
            int crowd = evens[1];

            // will print 2

            //q3
            int[] copy = new int[5];

            for (int i = 0; i < evens.Length; i++)
            {
                copy[i] += evens[i];


            }
        }
            //6 
        public static void Method() { 
            
        }

        //q5 
        public static void Parameter(int[,] array1, int[,] array2)
        {
            Console.WriteLine($"Length of array1: {array1.Length}, \n{array2.Length}");

        }
        //q6
        public static void Q6() {
            string[] names = { "sdays","asda","asdsd"};
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }
    }

}
