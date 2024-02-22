using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharpProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // WRITE AND VARIABLES
            //string characterName = "Tom";
            //int characterAge = 25;

            //Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //characterName = "Mike";
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);            

            //Console.ReadLine();

            // *********************************************************************
            // DATA TYPE
            //string phrase = "Ecole";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.3;
            //bool isMale = true;

            //Console.WriteLine()

            //Console.ReadLine();


            // *********************************************************************
            //WORKING WITH STRINGS
            //string phrase = "Univesite Laval" + " is cool!";
            //Console.WriteLine(phrase[0]);

            //Console.ReadLine();



            // *********************************************************************
            // WORKING WITH NUMBERS
            //int num = 6;
            //num++; 
            //Console.WriteLine(num);
            //Console.WriteLine(Math.Abs(-40));
            //Console.WriteLine(Math.Pow(2, 3));
            //Console.WriteLine(Math.Max(10, 15));
            //Console.WriteLine(Math.Round(10.7));

            //Console.ReadLine();


            // *********************************************************************
            // GETTING USER INPUT
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ". You are " + age + " years old.");

            //Console.ReadLine();


            // *********************************************************************
            // ARRAYS
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //luckyNumbers[1] = 600;
            //Console.WriteLine(luckyNumbers[1]);

            //string[] friends = new string[5]; // This array can hold 5 items
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //Console.ReadLine();


            // *********************************************************************
            // METHODS
            //string name = "Louis";
            //SayHi(name, 33);
            //SayHi("Marie", 41);

            //Console.ReadLine();



            // *********************************************************************
            // RETURN STATEMENTS
            //int cubeNumber = CalculateCube(3);
            //Console.WriteLine(CalculateCube(5));
            //Console.WriteLine(cubeNumber);
            //Console.ReadLine();


            // *********************************************************************
            // IF STATEMENT
            //bool isMale = true;
            //bool isTall = false;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //} else if (isMale && !isTall) {
            //    Console.WriteLine("You are a short male");
            //} else if (!isMale && !isTall)
            //{
            //    Console.WriteLine("You are not mal, not tall");
            //}
            //{
            //    Console.WriteLine("You are either not male or not tall or both");
            //}

            //Console.ReadLine();




            // *********************************************************************
            // IF STATEMENT (CON'T)
            //Console.WriteLine(GetMax(20, 10, 40));

            //Console.ReadLine();



            // *********************************************************************
            // SWITCH STATEMENT

            //Console.WriteLine(GetDay(2));

            //Console.ReadLine();

            // *********************************************************************
            // WHILE LOOPS
            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++ ;
            //}
            //Console.ReadLine();


            // *********************************************************************
            // FOR LOOPS
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++ ;
            //}

            // Console.ReadLine() ;

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //for (int i =0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}

            //Console.ReadLine();


            // *********************************************************************
            // BUILDING A EXPONENT METHOD
            //Console.WriteLine(GetPow(4, 3));

            //Console.ReadLine();


            // *********************************************************************
            // 2D ARRAYS
            //int[,] numberGrid =
            //{
            //    {1,2 },
            //    {3,4 }, 
            //    {5,6 }
            //};

            //Console.WriteLine(numberGrid[1,1]);

            //int[,] myArray = new int[2, 3];

            //Console.ReadLine();




            // *********************************************************************
            // COMMENTS





            // *********************************************************************
            // EXCEPTION HANDLING
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter an other number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("Format");
            //}
            //finally // No matter what, this code is gonna be executed
            //{
            //    Console.WriteLine("This is always executed");
            //}
    
            //Console.ReadLine();


            // *********************************************************************
            // CLASSES AND OBJECTS
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);

            Console.ReadLine();






        }
        // Methods goes outsite the Main method
        static void SayHi (string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int CalculateCube(int num)
        {
            int result = num * num * num;
            return result;
         
         }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3) {
                result = num1;
            } 
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } 
            else
            {
                result = num3;
            }


            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                        break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wenesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }


        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }

  
}
