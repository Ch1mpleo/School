using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Function
    {

        /// <summary>
        /// Display menu các tùy chọn
        /// </summary>
        public static void DisplayMenu()
        {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Compute BMI index");
                Console.WriteLine("2. Get the zodiac sign");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice (1-3): ");
        }

        /// <summary>
        /// Lấy giá trị lựa chọn của user và check validate
        /// </summary>
        /// <returns></returns>
        public static int GetUserChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }
            return choice;
        }

        /// <summary>
        /// Lấy giá trị user nhập vào là double và check validate
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double GetUserInputDouble(string input)
        {
            double userInput;
            while (true)
            {
                Console.Write(input);
                if (double.TryParse(Console.ReadLine(), out userInput) && userInput > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
            return userInput;
        }

        /// <summary>
        /// Lấy giá trị user nhập vào là int và check validate
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetUserInputInt(string input)
        {
            int userInput;
            while (true)
            {
                Console.Write(input);
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
            return userInput;
        }

    }
}
