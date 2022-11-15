namespace GuessTheNumber
{
    internal class Player
    {
        private readonly Game _game;

        public Player(Game game)
        {
            _game = game;
        }

        public int Guess()
        {
            Console.Write("Tipp et tall: ");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
