namespace GuessTheNumber
{
    class Game
    {
        private static readonly Random Random = new Random();
        private readonly int _correctNumber;
        public bool IsSolved { get; private set; }

        public Game()
        {
            _correctNumber = Random.Next(1, 100);
        }

        public Feedback Guess(int number)
        {
            var feedback =
                number == _correctNumber ? Feedback.Correct :
                number > _correctNumber ? Feedback.TooHigh :
                Feedback.TooLow;
            IsSolved = feedback == Feedback.Correct; 
            return feedback;
        }
    }
}
