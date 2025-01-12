
using MathConsoleGame.Game;

public static class GameManager
{
    public static Dictionary<int, string> Score { get; set; } = new();
    public static void Round()
    {
        DisplayController.PrintMenuOptions();
        var menuSelection = UserResponse.GetMenuSelection();

        while (menuSelection == MathConsoleGame.Globals.Mappings.MenuOption.GameHistory)
        {
            DisplayController.PrintGameScore(Score);

            DisplayController.PrintMenuOptions();
            menuSelection = UserResponse.GetMenuSelection();
        }

        QuestionAnswerHelper helper = new QuestionAnswerHelper(menuSelection);

        DisplayController.PrintUserQuestion(helper.QuestionAnswerInstance.Question);

        int userAnswer = UserResponse.GetUserAnswer();

        if (!isUserCorrect(userAnswer, helper.QuestionAnswerInstance.Answer))
        {
            Console.WriteLine($"Incorrect. The correct answer was {helper.QuestionAnswerInstance.Answer}");
        }
        else Console.WriteLine("Correct!");

        AddRoundResult(isUserCorrect(userAnswer, helper.QuestionAnswerInstance.Answer));
    }

    private static void AddRoundResult(bool isUserCorrect)
    {
        var lengthOfKeys = Score.Keys.ToArray().Length;

        if (isUserCorrect)
        {
            Score.Add(lengthOfKeys, "Win");
        }

        else
        {
            Score.Add(lengthOfKeys, "Loss");
        }
    }

    private static bool isUserCorrect(int userAnswer, int questionAnswer)
    {
        return userAnswer == questionAnswer;
    }
}