using GuessTheNumber;

var game = new Game();
while (!game.IsSolved)
{
    Console.Write("Tipp et tall: ");
    var number = Convert.ToInt32(Console.ReadLine());
    var feedback = game.Guess(number);
    var feedbackText = feedback switch
    {
        Feedback.Correct => "Riktig!",
        Feedback.TooHigh => "For høyt",
        Feedback.TooLow => "For lavt",
    };
    Console.WriteLine(feedbackText);
}