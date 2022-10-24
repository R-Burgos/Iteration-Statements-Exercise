namespace IterationStatements
{
    public class Program
    {
        //METHODS ----------------------------------------------------------------------------------------------------------------------------------------------

        //Write a method that will print to the console all numbers 1000 through -1000 - DONE!
        public static void PrintThousands()
        {
            for (int i = -1000; i >= -1000 && i < 1001; i++) //I went from -1000 to 1000 b/c that made more mathematical sense to me.
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE!
        public static void PrintByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE!
        public static void AreWeEqual() //If I wanted to explicitly define the numbers to compare inthe method I would have a return type other than void and in the Main method I would enter in the parameters of what numbers I wanted to compare.
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please enter two numbers to determine if they are equal:");
            var num1 = Console.ReadLine(); //Used Console.ReadLine to accept user inputs.  
            var num2 = Console.ReadLine();
            var check = (num1 == num2) ? $"{num1} and {num2} are equal." : $"{num1} and {num2} are not equal.";
            Console.WriteLine(check);
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOdd()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please enter a number to determine if it is even or odd:");
            var number = int.Parse(Console.ReadLine()); //I enjoy incorporating user inputs whenever possible. :)
            var check = (number % 2 == 0) ? $"{number} is even." : $"{number} is odd.";
            Console.WriteLine(check);
        }


        //Write a method to check whether a given number is positive or negative
        public static void PositiveNegative()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Please enter a number to determine if it is positive or negative:");
            var number = int.Parse(Console.ReadLine());
            var check = (number >= 0) ? $"{number} is positive." : $"{number} is negative.";
            Console.WriteLine(check);
        }

        //Write a method to read the age of a candidate and determine whether they can vote
        public static void CanIVote()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter your age to determine if you are old enough to vote:");
            var age = int.Parse(Console.ReadLine());
            // var ageCheck = (age >= 18) ? "You are able to vote!" : "Sorry, you are not old enough to vote yet.");
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                var years = 18 - age;
                var yearsLeft = (years >= 2) ? $"Only {years} years left until you can vote!" : $"Only {years} year left until you can vote!";
                //I used this ternary operator above because I wanted the output to read grammatically correct.
                Console.WriteLine(yearsLeft);
            }
        }

        //TRYPARSE METHOD FOR THE ABOVE
        public static void AgeCheck()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");
                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            Console.WriteLine((result < 18) ? "Very sorry. You are not old enough to vote." : "Congrats! You can vote!");
        }



        //Write a method to check if an integer (from the user) is in the range -10 to 10
        public static void RangeChecker()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter a number:");
            var integer = int.Parse(Console.ReadLine());
            var checkInteger = (integer >= -10 && integer <= 10) ? $"{integer} is in the range between -10 and 10." : $"{integer} is not in the range between -10 and 10.";
            Console.WriteLine(checkInteger);
        }

        //Write a method to display the multiplication table (from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a number to see the multiplication table of that number from 1 to 12:");
            var userNumber = int.Parse(Console.ReadLine());
            var ourTable = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (var row in ourTable)
            {
                Console.WriteLine($"{row} x {userNumber} = {row*userNumber}");
            }
        }

        // TRY PARSE FOR ABOVE

        public static void MultTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter an integer");
                cont = int.TryParse(Console.ReadLine(), out userInput);
            } while (!cont);

            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {userInput} = {i * userInput}");  //you can do math operations inside of a string interp. neat!
            }
        }
        


        static void Main(string[] args)
        {

            MultTable();
            Console.WriteLine("\n");
            AgeCheck();
            Console.WriteLine("\n");
            PrintThousands();
            Console.WriteLine("\n");
            PrintByThree();
            Console.WriteLine("\n");
            AreWeEqual();
            Console.WriteLine("\n");
            EvenOdd();
            Console.WriteLine("\n");
            PositiveNegative();
            Console.WriteLine("\n");
            CanIVote();
            Console.WriteLine("\n");
            RangeChecker();
            Console.WriteLine("\n");
            MultiplicationTable();
       
        }
    }
};
