using System;

namespace lab8080419
{
    class Program
    {

        static void Main(string[] args)
        {
            bool continu = true;
            while (continu == true)
            {
                Console.WriteLine(GetStudent());
                Console.WriteLine("Would you like to continue? Y/N");
                string answer = Console.ReadLine();
                string result = answer.Trim();
                if (result.ToLower() == "y")
                {
                    continu = true;
                }
                else
                {
                    Console.WriteLine("Thank You, Goodbye");
                    continu = false;
                }
            }
            Console.ReadKey();
        }
        public static int GetInput()
        {
            Console.WriteLine("Please input a valid integer");
            string GetInput = Console.ReadLine();
            int index = int.Parse(GetInput);
            return index;
        }
        public static string GetStudent()
        {
            string[] studentName = { "Dakota", "Josh", "Tommy", "James", "Maricela", "KimVy", "Sam", "Cody", "Flaka","Manik", "Mahruchi", "Moise", "Liz", "Jason", "Bob" };
            string[] homeTown = { "Kent City", "Grand Rapids", "Raleigh", "Grand Rapids", "Morelia", "Grand Rapids", "Grand Rapids", "Lawton", "Pristina", "Cox'sBazar","Teaneck", "Grand Rapids", "Earth", "Holland", "Metro Detroit" };
            string[] favoriteFood = { "Pho", "Tortellini", "Chicken Curry", "Cheese Burgers", "Tacos", "Sushi", "Tacos", "Potato Soup", "Thai", "Beef Curry","Chicken Wings", "Lasagna", "Salmon", "Burgers", "Burgers" };
            int input;
            try
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number 0 - 14)");
                input = GetInput();
                string studentinfo = "Student name " + studentName[input] + "  Hometown  " + homeTown[input] + " Favorite Food " + favoriteFood[input];
                return studentinfo;
            }
            catch (IndexOutOfRangeException e)
            {
                return "Student not found, try another index 0-14";
            }
        }
    }
}
