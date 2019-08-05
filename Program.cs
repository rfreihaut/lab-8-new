using System;

namespace lab8080419
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class");
            bool cont = true;
            while (cont == true)
            {
                Console.WriteLine(GetStudent());
                Console.WriteLine("Would you like to continuye? (Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    cont = true;
                }
                else
                {
                    Console.WriteLine("Thanks");
                    cont = false;
                }
            }
            Console.ReadKey();
        }
        public static int GetInput()
        {
            Console.WriteLine("Please input a valid int");
            string GetInput = Console.ReadLine();
            int index = int.Parse(GetInput);
            return index;
        }
        public static string GetStudent()
        {
            string[] studentName = { "Tommy", "Dekoda", "Cody", "Joshua", "Kim", "James", "Marcia", "Sam", "Manik" };
            string[] hometown = { "Ohio", "Kent", "Lawton", "Grand Rapids", "Grand Rapids", "Grand Rapids", "Morelia", "Grand Rapids", "Cox'sBazar" };
            string[] favoritFood = { "Chicken Curry", "Pho", "Potato Soup", "Cheese Tortellini", "Sushi", "Cheeseburgers", "Tacos", "Tacos", "Beef Curry" };
            int input;
            try
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number 1 - 10)");
                input = GetInput();
                string studentinfo = "Student name" + studentName[input - 1] + " Home town =" + hometown[input - 1] + "Favorit Food" + favoritFood[input - 1];
                return studentinfo;
            }
            catch (System.IndexOutOfRangeException)
            {
                return ("Student not found, try another index");
            }
        }
    }
}
