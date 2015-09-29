using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalloryKrauseLab2
{
    class Program
    {
        static void Main(string[] args)
        {




            //After you have collected this information, compute and print all values:
            //Full name and age of every person, including spouses.
            //Average age of all people.

            Person.AverageAge = 0;
            Person.SumOfAges = 0;
            Person.Count = 0;





            Person Person1 = new Person();
            System.Console.WriteLine("What is your first name?");
            Person1.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            Person1.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are you?");
            Person1.Age = int.Parse(System.Console.ReadLine());
            Person.Count++;
            Person.SumOfAges += Person1.Age;


            System.Console.WriteLine("Are you married?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {

                Person1.Spouse = new Person();

                System.Console.WriteLine("What is your spouse's name?");

                Person1.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is your spouse?");
                Person1.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.SumOfAges += Person1.Spouse.Age;


                Person1.Spouse.Spouse = Person1;

            }










            Person Person2 = new Person();
            System.Console.WriteLine("What is the first name of another person?");
            Person2.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is their last name?");
            Person2.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are they?");
            Person2.Age = int.Parse(System.Console.ReadLine());
            Person.Count++;
            Person.SumOfAges += Person2.Age;

            System.Console.WriteLine("Are they married?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {

                Person2.Spouse = new Person();

                System.Console.WriteLine("What is their spouse's name?");
                Person2.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is their spouse?");
                Person2.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.SumOfAges += Person2.Spouse.Age;



                Person2.Spouse.Spouse = Person2;


            }




            Person Person3 = new Person();
            System.Console.WriteLine("What is the first name of another person?");
            Person3.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is their last name?");
            Person3.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are they?");
            Person3.Age = int.Parse(System.Console.ReadLine());
            Person.Count++;
            Person.SumOfAges += Person3.Age;

            System.Console.WriteLine("Are they married?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {

                Person3.Spouse = new Person();

                System.Console.WriteLine("What is their spouse's name?");
                Person3.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is their spouse?");
                Person3.Spouse.Age = int.Parse(System.Console.ReadLine());

                Person.SumOfAges += Person3.Spouse.Age;

                Person3.Spouse.Spouse = Person3;
            }




            System.Console.WriteLine();
            Person1.PrintNameAndAge();
            if (Person1.IsMarried())
            {
                Person1.Spouse.PrintNameAndAge();

            }


            System.Console.WriteLine();
            Person2.PrintNameAndAge();
            if (Person2.IsMarried())

            {
                Person2.Spouse.PrintNameAndAge();

            }

            System.Console.WriteLine();
            Person3.PrintNameAndAge();
            if (Person3.IsMarried())

            {
                Person3.Spouse.PrintNameAndAge();
            }


            Person.AverageAge = Person.SumOfAges / Person.Count;
            System.Console.WriteLine("Average age of people: " + Person.AverageAge);
            System.Console.WriteLine("Press any key to continue");
            System.Console.ReadKey();













        }
    }
}
