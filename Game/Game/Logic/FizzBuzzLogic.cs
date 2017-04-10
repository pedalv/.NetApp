namespace Game.Logic
{
    public class FizzBuzzLogic
    {
        public static string ValidationRules(int i)
        {

            var fizzbuzz = string.Empty;

            if ((i % 5 == 0) && (i % 3 == 0))
            {
                fizzbuzz += "Fizzbuzz";

            }
            else if (i % 3 == 0)
            {
                fizzbuzz += "Fizz";

            }
            else if (i % 5 == 0)
            {
                fizzbuzz += "buzz";

            }
            else
            {
                fizzbuzz += i;

            }

            return fizzbuzz;
        }

    }
}
