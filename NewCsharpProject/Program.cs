using System;
using System.ComponentModel;
using System.Drawing;
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

            //Console.WriteLine("Simple Calculator");
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Choose an operation: +, -, *, / :  ");
            //char operation = Convert.ToChar(Console.ReadLine());
            //double result = 0;

            //if(operation =='+')
            //{
            //    result = num1 + num2;
            //}
            //else if (operation == '-')
            //{
            //    result = num1 - num2;
            //}
            //else if (operation == '*')
            //{
            //    result = num1 * num2;
            //}
            //else if (operation == '/')
            //{
            //    if(num2 != 0)
            //    {
            //        result = num1 / num2;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //        return; 
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation.");
            //    return; 
            //}

            //Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            #endregion

            #region Write a program to allow the user to enter a string and print the REVERSE of it

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();
            //char[] char_var = inputString.ToCharArray();


            //int length_var = char_var.Length;
            //for (int i = 0; i < length_var/ 2; i++)
            //{
            //    char temp= char_var[i];
            //    char_var[i] = char_var[length_var - 1];
            //    char_var[length_var - 1] = temp;

            //    length_var--;

            //}
            //Console.WriteLine($"The reverse of the string is: {new string(char_var)}");
            #endregion

            #region Write a program to allow the user to enter int and print the REVERSED of it
            //Same as above but for an integer input as we take integer as a string and can use the same logic

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();
            //char[] char_var = inputString.ToCharArray();


            //int length_var = char_var.Length;
            //for (int i = 0; i < length_var / 2; i++)
            //{
            //    char temp = char_var[i];
            //    char_var[i] = char_var[length_var - 1];
            //    char_var[length_var - 1] = temp;

            //    length_var--;

            //}
            //Console.WriteLine($"The reverse of the int is: {new string(char_var)}");

            #endregion

            #region Write a program in C# Sharp to find prime numbers within a range of numbers

            //Console.Write("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] values_prime=new int[num];
            //int index = 0;


            //while (num > 0)
            //{
            //    int flag = 1;
            //    if (num < 2)
            //    {
            //        flag = 0;

            //    }
            //    else
            //    {
            //        for (int i = 2; i < num; i++)
            //        {
            //            if (num % i == 0)
            //            {
            //                flag = 0;
            //            }
            //        }
            //    }

            //    if (flag == 1)
            //    {
            //        values_prime[index] = num;
            //        index++;
            //    }


            //    num--;
            //}

            //for(int x= 0; x < index; x++)
            //{
            //    Console.WriteLine(values_prime[x]);
            //}
            #endregion

            #region Write a program in C# Sharp to convert a decimal number into binary without using an array

            //Console.Write("Enter a number: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int[] res= new int[32]; 
            //int x = 0;
            //while (Number > 0)
            //{
            //    res[x] = Number & 1;
            //    Number=Number >> 1;
            //    x++;
            //}

            //Console.Write("binary is: ");
            //for (int i = x - 1; i >= 0; i--)
            //{
            //    Console.Write(res[i]);
            //}
            #endregion

            #region  Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line

            //Console.Write("enter x1: ");
            //int x1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("enter y1: ");
            //int y1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("enter x2: ");
            //int x2 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("enter y2: ");
            //int y2 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("enter x3: ");
            //int x3 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("enter y3: ");
            //int y3 = Convert.ToInt16(Console.ReadLine());

            //int lhs = (y2 - y1) * (x3 - x1);
            //int rhs = (y3 - y1) * (x2 - x1);

            //if(lhs == rhs)
            //{
            //    Console.WriteLine("all points in same triangle");
            //}
            //else
            //{
            //    Console.WriteLine("not all points in same triangle");
            //}


            #endregion

            #region Question18

            //while (true)
            //{
            //    Console.Write("Enter a duration for worker: ");
            //    int duration = Convert.ToInt32(Console.ReadLine());

            //    if (duration >=2 && duration <3)
            //    {
            //        Console.WriteLine("highly efficient");
            //    }
            //    else if (duration >= 3 && duration <4)
            //    {
            //        Console.WriteLine(" instructed to increase their speed");
            //    }
            //    else if (duration >= 4 && duration < 5)
            //    {
            //        Console.WriteLine("provided with training to enhance their speed");
            //    }
            //    else if (duration >= 5)
            //    {
            //        Console.WriteLine("required to leave the company");
            //    }
            //    else
            //    {

            //    }

            //}
            #endregion

            #endregion

            #region Assigment4

            #region Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n

            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write($"({i},{j} )");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Write a program in C# Sharp to find the sum of all elements of the array

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;

            //for(int i=0;i< array.Length;i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine($"The sum of all elements in the array is: {sum}");
            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

            //int[] array1 = { 1, 3, 5, 7, 9 };
            //int[] array2 = { 2, 4, 6, 8, 10 };

            //int[] mergedArray = new int[array1.Length + array2.Length];


            //for (int i = 0; i < (array1.Length); i++)
            //{
            //        mergedArray[i] = array1[i];         
            //}

            //for (int i = 0; i < (array2.Length); i++)
            //{
            //    mergedArray[i+array1.Length] = array2[i];
            //}

            //Array.Sort(mergedArray);

            //Console.WriteLine("Merged and sorted array:");
            //for (int i=0;i<(array1.Length+array2.Length);i++ )
            //{
            //    Console.Write(mergedArray[i] + " ");
            //}
            #endregion


            #region Write a program in C# Sharp to count the frequency of each element of an array

            int[] array1 = { 1, 3, 5, 7, 9, 11, 11, 2, 6, 8, 9, 4, 7, 12, 5, 5 };
            int[] counter=new int[100];

            for (int i = 0; i < array1.Length; i++)
            {

                counter[array1[i]]++;
            }

            for (int i = 0;i< array1.Length; i++)
            {
                
                Console.WriteLine($"{array1[i]} repeated : {counter[array1[i]]}");
            }

            #endregion
            #endregion
        }
    }
}

