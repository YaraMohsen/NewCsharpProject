using System;

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

            String IntStringVar = "150A";

            int.TryParse(IntStringVar, out int res);
            Console.WriteLine("The string is a valid integer: " + res);


            #endregion
        }
    }
}
