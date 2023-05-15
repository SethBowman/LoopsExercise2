namespace LoopsExercise3
{
    internal class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNums1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool TwoNumsSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are the same");
                return true;
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not the same");
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} = Even number");
            }
            else
            {
                Console.WriteLine($"{number} = Odd number");
            }

        }
        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is negative");
                return false;
            }

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int age);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age:");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to vote.");
                return false;
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the 10 range");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is not in 10 range");
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyThru12(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");               
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("Print numbers 1000 to -1000:");
            PrintNums1000();

            Console.WriteLine("Print numbers by 3:");
            UpBy3();

            Console.WriteLine("Are two numbers the same:");
            TwoNumsSame(2, 4);
            TwoNumsSame(10, 10);

            Console.WriteLine("Even or Odd:");
            EvenOrOdd(6);
            EvenOrOdd(3);

            Console.WriteLine("Is the number positive:");
            IsPositive(100);
            IsPositive(-55);

            Console.WriteLine("Can vote:");
            CanVote();

            Console.WriteLine("Ten range:");
            IsTenRange(15);
            IsTenRange(5);

            Console.WriteLine("Multiply through 12:");
            MultiplyThru12(2);
        }
    }
}