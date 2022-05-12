using System;
using System.IO;


namespace DayOne
    {
        class DayOneAnswers
        {

            #region First Quistion
            /*     Q1
                   Write a C# program. The program will ask for your name and will then greet you by name 
             */

            public static void Q1Func()
            {
                Console.WriteLine("Please enter ur name:");

                String username = Console.ReadLine();

                Console.WriteLine("Welcome {0}", username);

            }
            #endregion


            #region Second question
            /* Q2
             Write a program that uses exception handling to trap unexpected run-time errors.
            The program will prompt the user for two integer values. 
            It will divide the first integer by the second and display the result 
             */
            public static void Q2Func()
            {
                try
                {
                    Console.WriteLine("Please enter 2 numbers:");
                    Console.WriteLine("First number:");
                    int firstNumber = int.Parse(Console.ReadLine());


                    Console.WriteLine("second number:");
                    int secNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("the numbers are: first is {0}, sec is {1}", firstNumber, secNumber);
                }
                catch (Exception err)
                {
                    Console.WriteLine(" there is error and the error is {0}", err);
                }
            }
            #endregion


            #region Third Question
            /* Q3 
             By string: - Use Trim and Pad left and Join 

             By Math: - Calculate area of circle  
             */
            public static void Q3Ans()
            {

                // to use Trim 
                Console.WriteLine("Please enter text:");
                String sentence = Console.ReadLine();

                Console.WriteLine("Please enter the unwanted letters:");
                String trimLetters = Console.ReadLine();
                Char[] needsToRemove = trimLetters.ToCharArray();

                String trimValue = sentence.Trim(needsToRemove);


                // to check if the trim letter is exist
                if (trimValue == sentence)
                {
                    Console.WriteLine("There is no unwanted letter called '{0}' inside text '{1}'", trimLetters, sentence);

                }
                else
                {
                    Console.WriteLine("the sentence after trimming: {0}", trimValue.PadLeft(5));
                }


                // Circle area 
                // area = Pi * radius power2
                Console.WriteLine("Radius is :");
                int r = int.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Area is : {0}", area);
            }
            #endregion



            #region Forth Question
            /* Q4  
             * redirect Read line form file 
             */

            public static void Q4Ans()
            {
                try
                {

                    // create the file 
                    Console.WriteLine("put any value to text file:");
                    String value = Console.ReadLine();
                    FileStream fs = new FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                     
                    TextWriter oldWriter = Console.Out;


                    sw.Close();
                    fs.Close();

                    Console.SetOut(oldWriter);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }


                //read From the new file 
                try
                {

                    StreamReader sr = new StreamReader("Test.txt");
                    String readFromFile = sr.ReadLine();
                    Console.WriteLine("Value from file is : {0}", readFromFile);

                }
                catch (Exception err)
                {
                    Console.WriteLine(err);

                }

            }

            #endregion
        }
    }






