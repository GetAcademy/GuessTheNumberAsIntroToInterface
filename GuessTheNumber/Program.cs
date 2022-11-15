using GuessTheNumber;

/*
 * Ønske fra dere: GIT
 * Enkelt eksempel på interface
 * Polymorfisme
 * Dependency inversion principle
 * Ev. dependency injection
 * Oversikt over innholdet på Moodle
 */

var game = new Game();
//IPlayer player = null;
IPlayer player = new HumanPlayer();
//IPlayer player = new RobotPlayer();
while (!game.IsSolved)
{
    var number = player.Guess();
    var feedback = game.Guess(number);
    var feedbackText = feedback switch
    {
        Feedback.Correct => "Riktig!",
        Feedback.TooHigh => "For høyt",
        Feedback.TooLow => "For lavt",
    };
    Console.WriteLine(feedbackText);
    player.ReceiveFeedback(feedback, number);
}