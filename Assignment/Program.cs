namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                // Hiển thị menu
                Function.DisplayMenu();

                // Nhập lựa chọn từ người dùng và kiểm tra đầu vào
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            double height = Function.GetUserInputDouble("Enter your height: ");
                            double weight = Function.GetUserInputDouble("Enter your weight: ");

                            Console.WriteLine($"Your BMI: {BMI.BmiCalculator.GetBmi(weight, height)}");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;

                        case 2:
                            int day = Function.GetUserInputInt("Enter your birth day: ");
                            int month = Function.GetUserInputInt("Enter your birth month: ");

                            string yourZodiacSign = Zodiac.ZodiacCalculator.GetZodiacEnglish(month, day);
                            Console.WriteLine($"Your Zodiac sign is: {yourZodiacSign}");
                            Console.WriteLine($"Cung hoàng đạo của bạn là: {Zodiac.ZodiacCalculator.GetZodiacVietnamese(yourZodiacSign)}");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                            break;
                    }
                }
                else
                {
                    // Đầu vào không phải là số nguyên
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ReadLine(); // Đọc và bỏ qua đầu vào không hợp lệ
                }

            } while (choice != 3);
        }
    }
}
