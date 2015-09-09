using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {





            System.Console.Write("What is your first name? ");
            string firstName;
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            string middleInitial;
            middleInitial = System.Console.ReadLine();


            System.Console.Write("What is your last name? ");
            string lastName;
            lastName = System.Console.ReadLine();


            string fullName;
            fullName = "firstName" + " " + "middleInitial" + ". " + "lastName";


            System.Console.Write("What is your height in feet? ");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());


            System.Console.Write("How many inches off your base height in feet? ");
            double heightInches;
            heightInches = double.Parse(System.Console.ReadLine());

            double totalHeightCM;
            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;


            System.Console.Write("How old are you? ");
            int age;
            age = int.Parse(System.Console.ReadLine());





            System.Console.Write("Are you a citizen? ");
            bool isCitizen;
            isCitizen = System.Console.ReadLine();

           bool yes = true;
          //  bool no = false;

            // ***** Tried to fix this for hours, could not find a solution
            //in the notes/videos/examples/etc. *********

            //  isCitizen = yes = true;
            // isCitizen no = false;




            bool canVote;
            // canVote = age >= 18;    
            canVote = (age >= 18) || (isCitizen = false);
            //canVote bool (age < 18) && (isCitzen = false) = false



            System.Console.Write("Your name is : ");          
            System.Console.WriteLine(fullName);


            System.Console.Write("Your height in CM is : ");
            System.Console.Write(totalHeightCM);

            System.Console.Write("Can you vote?: ");
           System.Console.Write(canVote);






        }
    }
}
