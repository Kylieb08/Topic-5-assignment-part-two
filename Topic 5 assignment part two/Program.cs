namespace Topic_5_assignment_part_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int secretNumber = 7;
            int guess;

            Console.WriteLine("Hello. In order to continue, you must guess a number between 1 and 10");
            Console.WriteLine("Please enter your guess here: ");
            Int32.TryParse(Console.ReadLine(), out guess);

            if (guess == secretNumber)
            {
                Console.WriteLine("Correct");
            }
            else { Console.WriteLine("Incorrect. the number was " + secretNumber); }
        }
    }
}
