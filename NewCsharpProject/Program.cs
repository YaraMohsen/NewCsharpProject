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
            test_ref new_obj1 = new test_ref();
            test_ref new_obj2 = new test_ref();

            new_obj1.x = 7;
            new_obj2 = new_obj1;

            new_obj2.x = 9;

            Console.WriteLine($"new_obj1.x = {new_obj1.x}, new_obj2.x = {new_obj2.x}"); 
            // new_obj1 .x will also be 9 because new_obj2 is a reference to the same object as new_obj1

            #endregion
        }
    }
}
