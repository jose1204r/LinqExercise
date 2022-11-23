﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sm = numbers.Sum();
            Console.WriteLine(sm);

            //TODO: Print the Average of numbers

            var avr = numbers.Average();
            Console.WriteLine(avr);

            //TODO: Order numbers in ascending order and print to the console
            var asn = numbers.OrderBy(x => x);
            Console.WriteLine("*****************Acending*********************** ");

            foreach (var x in asn)
                Console.WriteLine(x);

            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("*****************Decending*********************** ");
           var adsn = numbers.OrderByDescending(x => x);
           foreach(var x in adsn)
                Console.WriteLine(x);




            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("***************** Greater Than 6 *********************** ");
           var greather = numbers.Where(x => x > 6);
           foreach (var x in greather) 
            {
              Console.WriteLine(x);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("***************** Print only 4 of them *********************** ");
            foreach (var item in asn.Take(4))
            {
                Console.WriteLine(item);

            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("*****************AGE **************************");
            numbers[4] = 35;
            foreach (var items in numbers.OrderByDescending(x => x))
            {
            
             Console.WriteLine(items);
            
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var Ordename = employees.Where(person => person.FirstName.StartsWith("C")|| person.FirstName.StartsWith("S"));
            foreach (var name in Ordename) { Console.WriteLine(name.FirstName); }


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var employesAge = employees.Where(emp => emp.Age > 26)
                .OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName)
                .ThenBy(emp => emp.YearsOfExperience);

           foreach (var x in employesAge)
                { Console.WriteLine($"Name :{x.FullName} AGE :{x.Age} Experience :{x.YearsOfExperience}"); }

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("JOSE","Rodriguez", 25, 1)).ToList();
           
            foreach (var item in employees)
                { Console.WriteLine($"{item.FirstName} {item.LastName}"); }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            
            return employees;
        }
        #endregion
    }
}
