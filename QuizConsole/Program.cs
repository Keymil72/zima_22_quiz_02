using QuizConsole;
using QuizConsole.Models;


var person1 = new Person("Jan", "Nowak", "2518");





var game = new Game();
var message = new Message();
message.DisplayWelcome();

while(true)
{
    game.DrawQuestion();
    var playerAnswer = game.CurrentQuestion.Display(game.IsWheelAvailable, game.CorrectKeys);
    if (playerAnswer == 5)
    {
        game.IsWheelAvailable = false;
        game.GetQuestionWithTwoAnswers();
        playerAnswer = game.CurrentQuestion.Display(game.IsWheelAvailable, game.CorrectKeys);
        game.CorrectKeys.Clear();
        game.CorrectKeys = new List<int> { 1, 2, 3, 4 };
    }
    
    if (game.CheckIfAnswerCorrect(playerAnswer))
    {
        if (game.CheckIfLastQuestion())
        {
            message.FinalScreen();
            break;
        }
        else
        {
            message.GoodAnswerMessage();
        }
    }
    else
    {
        message.DisplayGameOver();
        break;
    }
}




