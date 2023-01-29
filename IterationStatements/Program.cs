namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE
        public static void AllNumbers()
        {
            for (int i = 1000;i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE
        public static void ByThree()
        {
            for (int i = 3; i <= 999; i+= 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE
        public static string EqualOrNot(int integerOne, int integerTwo)
        {
            return (integerOne == integerTwo) ? $"{integerOne} and {integerTwo} ARE equal" : $"{integerOne} and {integerTwo} are NOT equal";
        }

        //Write a method to check whether a given number is even or odd - DONE
        public static string EvenOrOdd(int number)
        {
            return (number % 2 == 0) ? $"{number} is even" : $"{number} is odd";
        }

        //Write a method to check whether a given number is positive or negative - DONE
        public static string PositiveOrNegative(int number)
        {
            return (number >= 0) ? $"{number} is positive" : $"{number} is negative";
        }

        //Write a method to read the age of a candidate and determine whether they can vote. - DONE
        //Hint: Use Parse or the safer TryParse() for an extra challenge - DONE
        //Parse() - used TryParse()
        //TryParse() - DONE
        public static void VotingAge()
        {
            int age;
            Console.Write("How old are you: ");
            var isNumber = int.TryParse(Console.ReadLine(), out age);
            while (!isNumber)
            {
                Console.Write("Please enter a valid integer for age: ");
                isNumber = int.TryParse(Console.ReadLine(), out age);
            }
            Console.WriteLine((age >= 18) ? "You can vote" : "Sorry, you are not old enough to vote");
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - DONE
        public static void IntegerInRange()
        {
            Console.Write("Input an integer: ");
            var rangeInteger = int.Parse(Console.ReadLine());
            Console.WriteLine((rangeInteger >= -10 && rangeInteger <= 10) ? $"{rangeInteger} is between -10 and 10" : $"{rangeInteger} is not between -10 and 10");
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer - DONE
        public static void MultiplicationTable()
        {
            Console.Write("Input an integer: ");
            var multiplicationInteger = int.Parse(Console.ReadLine());
            Console.WriteLine(
                $"{multiplicationInteger} x 1 = {multiplicationInteger * 1}\n" +
                $"{multiplicationInteger} x 2 = {multiplicationInteger * 2}\n" +
                $"{multiplicationInteger} x 3 = {multiplicationInteger * 3}\n" +
                $"{multiplicationInteger} x 4 = {multiplicationInteger * 4}\n" +
                $"{multiplicationInteger} x 5 = {multiplicationInteger * 5}\n" +
                $"{multiplicationInteger} x 6 = {multiplicationInteger * 6}\n" +
                $"{multiplicationInteger} x 7 = {multiplicationInteger * 7}\n" +
                $"{multiplicationInteger} x 8 = {multiplicationInteger * 8}\n" +
                $"{multiplicationInteger} x 9 = {multiplicationInteger * 9}\n" +
                $"{multiplicationInteger} x 10 = {multiplicationInteger * 10}\n" +
                $"{multiplicationInteger} x 11 = {multiplicationInteger * 11}\n" +
                $"{multiplicationInteger} x 12 = {multiplicationInteger * 12}\n");
        }

        //Call the methods to test them in the Main method below - DONE
        static void Main(string[] args)
        {
            AllNumbers();
            ByThree();

            // The following lines are for the EqualOrNot() method
            Console.WriteLine("*****The EqualOrNot() Method*****");
            Console.Write("Input the first integer: ");
            var integerOne = int.Parse(Console.ReadLine());
            Console.Write("Input the second integer: ");
            var integerTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(EqualOrNot(integerOne, integerTwo));

            // The following lines are for the EvenOrOdd() method, the variable created here will also be used for the PositiveOrNegative() method
            Console.WriteLine("*****The EvenOrOdd() Method*****");
            Console.Write("Input an integer to see some info about it: "); 
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(number));

            // The following lines are for the PositiveOrNegative() method
            Console.WriteLine("*****The PositiveOrNegative() Method*****");
            Console.WriteLine(PositiveOrNegative(number));

            // The following lines are for the VotingAge() method
            Console.WriteLine("*****The VotingAge() Method*****");
            VotingAge();

            // The following lines are for the IntegerInRange() method
            Console.WriteLine("*****The IntegerInRange() Method*****");
            IntegerInRange();

            // The following lines are for the MultiplicationTable() method
            Console.WriteLine("*****The MultiplicationTable() Method*****");
            MultiplicationTable();
        }
    }
}
