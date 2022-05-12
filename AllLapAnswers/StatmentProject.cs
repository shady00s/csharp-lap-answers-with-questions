using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoStatment


/*
 Exercise 1
Write a program that reads an integer day number 
(between 1 and 365) from the console and stores it in an integer variable. The program will convert this number into a month and a day of the month and then print the result to the console. For example, entering 40 should result in “February 9” being displayed. (In this exercise, the complications associated with leap years are ignored.)
Exercise 2
You will add functionality to the program that you created in
Exercise 1. The program will examine the initial day number that is entered by the user. If it is less than 1 or greater than 365, the program will throw an InvalidArgument exception (“Day out of range”). The program will trap this exception in a catch clause and display a diagnostic message on the console.

 */
{
    // days class

    class DaysVal
    {
        public String Name { get; set; }
        public int val { get; set; }
    }

    // days list

    class MonthsValue   
    {

        public String MonthName { get; set; }
        public int MonthVal  { get; set; }

}


 


class StatmentProject
    {

       

        public static void CalenderApp(int dayValue , bool isLeep) {


            List<DaysVal> dayvals = new List<DaysVal>{
            new DaysVal{Name ="Saterday",val =1 },
            new DaysVal{Name ="Sunday",val =2 },
            new DaysVal{Name ="Monday",val =3 },
            new DaysVal{Name ="Tuesday",val =4 },
            new DaysVal{Name ="Wednesday",val =5 },
            new DaysVal{Name ="Thursday",val =6 },
            new DaysVal{Name ="Friday",val =7 },

        };

                

                if (dayValue > 365 || dayValue > 366)
                {
                    Console.WriteLine("Please enter valid day");
                }
                //for the non leap year

                else 
                {
                    // make loop and subtract days value from monthsVal enum and add one into number of months variable
                     
                    List<MonthsValue> monthsVals = new List<MonthsValue> {

                new MonthsValue{MonthName = "jan", MonthVal = 31},
                new MonthsValue{MonthName = "feb", MonthVal = (isLeep == false ? 28 : 29)},
                new MonthsValue{MonthName = "mar", MonthVal = 31},
                new MonthsValue{MonthName = "apr", MonthVal = 30},
                new MonthsValue{MonthName = "may", MonthVal = 31},
                new MonthsValue{MonthName = "june",MonthVal = 30},
                new MonthsValue{MonthName = "july",MonthVal = 31},
                new MonthsValue{MonthName = "aug", MonthVal = 31},
                new MonthsValue{MonthName = "sept",MonthVal = 30},
                new MonthsValue{MonthName = "oct", MonthVal = 31},
                new MonthsValue{MonthName = "nov", MonthVal = 30},
                new MonthsValue{MonthName = "dec", MonthVal = 31},
            };

                    string[] nameOfMonth = monthsVals.Select(d => d.MonthName).ToArray();
                    int[] val = monthsVals.Select(d => d.MonthVal).ToArray();

                    int[] daysOfWeekValue = dayvals.Select(d => d.val).ToArray();

                    int monthNumber = dayValue / 31;
                    int dayCal = 0;
                    int valueOFTheDay = 0;
                    if (dayValue <= 31)
                    {
                        Console.WriteLine($"The Date is {dayValue }/ {nameOfMonth.First()} ");
                    }
                    else
                    {
                        for (int x = 0; x < monthNumber; x++)
                        {
                            //to create the number of the days 
                            dayCal += val[x];
                            valueOFTheDay = dayValue - dayCal;
                        }
                        Console.WriteLine($"The Date is   {valueOFTheDay}/ {nameOfMonth[monthNumber]}  ");
                    }
                }

            }



      

        
        }

    





