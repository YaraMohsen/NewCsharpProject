using System;
using System.ComponentModel;
using System.Xml.Linq;
class test_ref
{
    public int x = 10;
    public int y = 20;
}

namespace NewCsharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assigment2


            #region Question1

            //Console.WriteLine("enter the number");
            //String read_number = Console.ReadLine();

            //Console.WriteLine("You enter :" + read_number);

            #endregion

            #region Question2

            //String IntStringVar = "150A";

            //int.TryParse(IntStringVar, out int res);
            //Console.WriteLine("The string is a valid integer: " + res);


            #endregion

            #region Question3

            //float DividToInt = 10.6f;
            //int int_value = (int)DividToInt; //explicit casting

            //Console.WriteLine(int_value);
            #endregion


            #region Question4

            #endregion

            #region Question5
            //int y = 5;
            //int x = y;
            //x++;
            //Console.WriteLine($"{x},{y}");
            #endregion

            #region Question6
            //test_ref new_obj1 = new test_ref();
            //test_ref new_obj2 = new test_ref();

            //new_obj1.x = 7;
            //new_obj2 = new_obj1;

            //new_obj2.x = 9;

            //Console.WriteLine($"new_obj1.x = {new_obj1.x}, new_obj2.x = {new_obj2.x}"); 
            //// new_obj1 .x will also be 9 because new_obj2 is a reference to the same object as new_obj1


            #endregion

            #region question7
            //Console.Write("Enter a your first name:");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter a your second name:");
            //string str2 = Console.ReadLine();

            //Console.Write($"your full name is: {str1} {str2}");

            #endregion


            #region question8

            //Interest = (principal * rate * time ) /100.

            //Console.Write("Enter the principal amount: ");
            //int principal = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the rate amount: ");
            //int rate = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the Time amount: ");
            //int Time = Convert.ToInt32(Console.Read());

            //double interest = (principal * rate * Time) / 100.0;
            //Console.WriteLine($"The interest is: {interest}%");
            #endregion

            #region question9
            //BMI = (Weight)/(Height*Height)

            //Console.Write("Enter your weight in kg: ");
            //double weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter your height in meters: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double bmi = weight / (height * height);
            //   Console.WriteLine($"Your BMI is: {bmi}");
            #endregion

            #region question10
            //while (true)
            //{
            //    Console.Write("Enter a temperature in: ");
            //    double temp = Convert.ToDouble(Console.ReadLine());

            //    if (temp > 30)
            //    {
            //        Console.WriteLine("just hot");
            //    }

            //    else if (temp < 10)
            //    {
            //        Console.WriteLine("just cold");
            //    }

            //    else
            //    {
            //        Console.WriteLine("just good");
            //    }

            //}
            #endregion

            #region question11
            //Console.Write("Enter a day : ");
            //int day=Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a  month : ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Todays date is: {day},{month},{year}");
            //Console.WriteLine($"Todays date is: {day}/{month}/{year}");
            //Console.WriteLine($"Todays date is: {day}-{month}-{year}");
            #endregion

            #region question12

            //DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //The event is on 06/14/2024
            #endregion

            #endregion

            #region Assigment3
            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            //Write a program that takes a number from the user then
            //print yes if that number can be divided by 3 and 4 otherwise print no

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive

            //Console.Write("Enter an integer: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //if (userInput < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}
            #endregion

            #region Write a program that takes 3 integers from the user then prints the max element and the min element

            //Console.Write("Enter first integer1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter first integer2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter first integer1: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = 0;
            //int min = num1;

            //if (num1 > num2)
            //{
            //    max = (num1 > num3) ? num1 : num3;
            //    min= (num2 < num3) ? num2 : num3;
            //}
            //else
            //{
            //    max = (num2 > num3) ? num2 : num3;
            //    min = (num1 < num3) ? num1 : num3;
            //}

            //Console.WriteLine($"max num is {max}");
            #endregion

            #region Write a program that allows the user to insert an integer number then check If a number is even or odd

            //Console.Write("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Enter character: ");
            //string character_check = Console.ReadLine();
            ////the returned string contains from 2 bytes, the first byte is the character  and the second byte is Null terminator
            ////so we need to check the first byte only

            //if (character_check[0] =='a' || character_check[0] == 'e' || character_check[0] == 'i' || character_check[0] == 'o' || character_check[0] == 'u' ||
            //   character_check[0] == 'A' || character_check[0] == 'E' || character_check[0] == 'I' || character_check[0] == 'O' || character_check[0] == 'U')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion

            #region Write a program that allows the user to insert an integer then print all numbers between 1 to that number

            //Console.Write("Enter integer: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Write a program that allows the user to insert an integer then print a multiplication table up to 12

            //Console.Write("Enter integer: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i}*{num}= {i * num}");
            //}

            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter integer: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion

            #region Write a program that takes two integers then prints the power

            //Console.Write("Enter number: "); 
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number: ");
            //int power = Convert.ToInt32(Console.ReadLine());

            //int res = 1;

            //for(int i = 1; i <= power; i++)
            //{
            //    res *= num;
            //}

            //Console.WriteLine($"The result of {res} ");

            #endregion

            #region  Write a program to enter marks of five subjects and calculate total, average and percentage

            //Console.Write("enter 5 marks:");
            //String string_input= Console.ReadLine();
            //char[] str_marks = new char[6];
            //int counter = 0;

            //// Assuming the input is space-separated marks, e.g., "85 90 78 88 92"
            //int mark1=0, mark2=0, mark3=0, mark4 = 0, mark5 = 0;
            //int x = 0;
            //for (int i=0;i< string_input.Length; i++)
            //{

            //    str_marks[x] = string_input[i];
            //    x++;
            //    if (string_input[i] == ' ' || ((i+1) == string_input.Length))
            //    {
            //        x = 0;
            //        counter++;
            //        if (counter == 1)
            //        {
            //            mark1 = Convert.ToInt32(new string(str_marks));
            //            str_marks = new char[6]; // Reset the array for the next mark
            //        }
            //        else if (counter == 2)
            //        {
            //            mark2 = Convert.ToInt32(new string(str_marks));
            //            str_marks = new char[6];
            //        }
            //        else if (counter == 3)
            //        {
            //            mark3 = Convert.ToInt32(new string(str_marks));
            //            str_marks = new char[6];
            //        }
            //        else if (counter == 4)
            //        {
            //            mark4 = Convert.ToInt32(new string(str_marks));
            //            str_marks = new char[6];
            //        }
            //        else if (counter == 5)
            //        {
            //            mark5 = Convert.ToInt32(new string(str_marks));
            //            str_marks = new char[6];
            //        }
            //    }
            //}
            //Console.WriteLine($"The total marks is: {mark1 + mark2 + mark3 + mark4 + mark5}");
            //Console.WriteLine($"The average marks is: {(mark1 + mark2 + mark3 + mark4 + mark5) / 5}");
            //Console.WriteLine($"The percentage is: {(mark1 + mark2 + mark3 + mark4 + mark5) / 5}%");


            #endregion

            #region Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter month number (1-12): ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());
            //int daysInMonth;
            //switch (monthNumber)
            //{
            //    case 1: // January
            //    case 3: // March
            //    case 5: // May
            //    case 7: // July
            //    case 8: // August
            //    case 10: // October
            //    case 12: // December
            //        daysInMonth = 31;
            //        break;
            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        daysInMonth = 30;
            //        break;
            //    case 2: // February
            //        daysInMonth = 28; // Assuming non-leap year for simplicity
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return; // Exit the program if the month number is invalid
            //}
            #endregion

            #region Write a program to create a Simple Calculator.

            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose an operation: +, -, *, / :  ");
            char operation = Convert.ToChar(Console.ReadLine());
            double result = 0;

            if(operation =='+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return; 
                }
            }
            else
            {
                Console.WriteLine("Invalid operation.");
                return; 
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            #endregion







            #endregion


        }
    }
}
