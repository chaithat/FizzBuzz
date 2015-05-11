
namespace FizzBuzzLibrary
{
    public class FizzBuzzLib
    {
        private const string FizzMessage = "Fizz";
        private const string BuzzMessage = "Buzz";

        public string Count(int number)
        {
            string response = string.Empty;
            if (isFizz(number))
            {
                response += FizzMessage;
            }

            if (isBuzz(number))
            {
                response += BuzzMessage;
            }

            if (string.IsNullOrEmpty(response))
            {
                response = number.ToString();
            }
            return response;
        }

        private static bool isBuzz(int number)
        {
            return number % 5 == 0;
        }

        private static bool isFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}
