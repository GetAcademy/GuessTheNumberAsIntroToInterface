namespace GuessTheNumber
{
    internal class HumanPlayer
    {
        public int Guess()
        {
            Console.Write("Tipp et tall: ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
