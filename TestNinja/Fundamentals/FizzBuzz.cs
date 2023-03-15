namespace TestNinja.Fundamentals
{
    public class FizzBuzz
    {
        //Write a function that takes a "Number" and returns a "String"
        public static string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString(); 
        }
    }
}