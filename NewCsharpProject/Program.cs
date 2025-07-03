using System;
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
            Console.Write("Enter a day : ");
            int day=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a  month : ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Todays date is: {day},{month},{year}");
            Console.WriteLine($"Todays date is: {day}/{month}/{year}");
            Console.WriteLine($"Todays date is: {day}-{month}-{year}");
            #endregion
        }
    }
}
