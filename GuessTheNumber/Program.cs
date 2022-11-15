using GuessTheNumber;

/*
 * Enkelt eksempel på interface
 * Dependency inversion principle
 * Ev. dependency injection
 * Oversikt over innholdet på Moodle
 */

var game = new Game();
var player = new Player(game);
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
}