namespace GuessTheNumber
{
    class Game
    {
        private readonly int _correctNumber;
        public bool IsSolved { get; private set; }

        public Game()
        {
            var random = new Random();
            _correctNumber = random.Next(1, 100);
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
