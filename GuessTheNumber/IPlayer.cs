namespace GuessTheNumber
{
    internal interface IPlayer
    {
        int Guess();
        void ReceiveFeedback(Feedback feedback, int number);
    }
}
