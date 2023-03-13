/*
 * Author: Jaime Garcia
 * Course: COMP003A
 * Purpose: Final Project - Dating App "Lovers or Friends"
 * Resources: COMP003A lecture and hw activities and http://www.stackoverflow.com
 * 
 */



using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Lovers or Friends Profile Set-Up Page, Welcome!");

            //FIRSTNAME SECTION
            char[] arr = new char[26];
            Console.WriteLine("Please enter your first name: ");
            string firstname = Console.ReadLine(); //stores firstname input

            if (Regex.IsMatch(firstname, @"^[a-zA-Z]+$"))
            {
                arr = firstname.ToCharArray();
            }
            else
            {
                Console.WriteLine("Please enter a character from A-Z.");
                return;
            }


            //LASTNAME SECTION
            char[] arr2= new char[26];
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine(); //stores input
            if (Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                arr2 = lastName.ToCharArray();
            }
            else
            {
                Console.WriteLine("Please enter a character from A-Z.");
                Console.ReadLine(); //captures input again if not met the first time
            }


            //BIRTHYEAR SECTION
            Console.WriteLine("Please enter your birth year(yyyy): ");
            double birthYear = Convert.ToDouble(Console.ReadLine()); //stores input
            if (birthYear >= 1900 && birthYear <= 2023)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Enter a year between 1900-2023");
                Console.ReadLine(); //captures input between the correct years
            }





            //GENDER SECTION
            Console.WriteLine("Please enter your gender: (ex. M, Male, F, Female, O, Other)");
            string gender = Console.ReadLine().ToLower();
            while (gender != "Male" && gender != "M" && gender != "male" && gender != "m" && gender != "Female" &&
                gender != "female" && gender != "F" && gender != "f" && gender != "Other" && gender != "other" && gender != "O" && gender != "o")
            {
                Console.WriteLine("Please only type ex. M, Male, F, Female, O, Other");
                gender = Console.ReadLine().ToLower();
            }
            


            Console.WriteLine("\n");

            //DATING QUESTION SECTION
            var datingQuestions = new List<string>();
            datingQuestions.Add("1. Describe your perfect first date:");
            datingQuestions.Add("2. What do you look for in a partner?");
            datingQuestions.Add("3. What does your typical day look like?");
            datingQuestions.Add("4. What are you current goals/aspirations?");
            datingQuestions.Add("5. Do you care about the religion of your partner?");
            datingQuestions.Add("6. Do you care about the political views of your partner?");
            datingQuestions.Add("7. What is your current occupation?");
            datingQuestions.Add("8. Do you like pets?");
            datingQuestions.Add("9. Why are you looking to date?");
            datingQuestions.Add("10. What inspires you the most?");
            

            // Reverse the output to show recent input first (starts at 10 and counts down)
            datingQuestions.Reverse();

            //using for loop
            for (int i = 0; i < datingQuestions.Count; i++)
            {
                Console.WriteLine(datingQuestions[i]);
                var ListInput = Console.ReadLine(); //stores input
            }
            
            



            /*
            for (int i = 1; i < datingQuestions.Count; i++) // Continue For Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "Describe your perfect first date:"); // Asks for user input
                var ListInput = Console.ReadLine(); // User inputs value
                break;

            }
            for (int i = 2; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i +". " + "What do you look for in a partner?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 3; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "What does your typical day look like?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 4; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "What are you current goals/aspirations?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 5; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "Do you care about religion of your partner?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 6; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "Do you care about the political views of your partner?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 7; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "What is your current occupation?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 8; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "Do you like pets?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 9; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "Why are you looking to date?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 10; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "What inspires you the most?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;


            }
            for (int i = 11; i < datingQuestions.Count; i++) // continue for Loop until i is > List amount.
            {
                Console.WriteLine(i + ". " + "What inspires you the most?"); // asks for user input
                var ListInput = Console.ReadLine(); // user inputs value
                break;
            } */





            Console.WriteLine("\n");

            ///// Profile return summary for user input 
            SectionSeparator("Lovers or Friends Profile Summary");        
        
            Console.WriteLine($"Hello {lastName}, {firstname}! Welcome to Lovers or Friends, this is your dating profile summary:");
            Console.WriteLine("\n");
            AgeCalculator(birthYear);
            GenderDisplay(gender);


            Console.WriteLine("\n");
             // datingQuestions.Remove("11"); //removes a specific value somewhere inside the collection (removed during testing/debugging)

            ListTransversal(datingQuestions);
            
            
        
        }

        ///<summary>
        ///Section separator method
        /// </summary>
        /// <param name="section">String input for section name</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(80, '*') + $"\n\t\t{section} \n" + "".PadRight(80, '*'));
        }

        ///<summary>
        ///Array traversal
        /// </summary>
        ///<param name="item">string input</param>

        static void ListTransversal(List<string> list)
        {
            //you can use a for-loop or other looping statements for array traversals
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }

        /// <summary>
        /// Method overloading with multiple parameters but no return value
        /// </summary>
        /// <param name="inputYear">Integer input</param>
        static void AgeCalculator(double inputYear)
        {
            Console.WriteLine($"You will be {DateTime.Now.Year - inputYear} years old this year, congrats! :)");
            //you can add more code here
        }
        /// <summary>
        /// Method overloading with multiple parameters but no return value
        /// </summary>
        /// <param name="inputGender">gender input</param>
        static void GenderDisplay(string inputGender)
        {
            Console.WriteLine($"You have stated that you identify as {inputGender}");
            //you can add more code here
        }




    }
}