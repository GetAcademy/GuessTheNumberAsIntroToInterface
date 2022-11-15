namespace GuessTheNumber
{
    internal class HumanPlayer : IPlayer
    {
        public int Guess()
        {
            Console.Write("Tipp et tall: ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public void ReceiveFeedback(Feedback feedback, int number)
        {
        }
    }
}
