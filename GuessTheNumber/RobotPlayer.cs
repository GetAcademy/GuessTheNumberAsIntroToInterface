namespace GuessTheNumber
{
    internal class RobotPlayer
    {
        private int _min;
        private int _max;

        public RobotPlayer()
        {
            _min = 1;
            _max = 100;
        }

        public int Guess()
        {
            var number = (_min + _max) / 2;
            Console.WriteLine($"Tipper {number}");
            return number;
        }

        public void ReceiveFeedback(Feedback feedback, int number)
        {
            if (feedback == Feedback.TooHigh)
            {
                _max = number;
            }
            else if (feedback == Feedback.TooLow)
            {
                _min = number;
            }
        }
    }
}
