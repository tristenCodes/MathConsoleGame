namespace MathConsoleGame.Game;
using MathConsoleGame.Globals;

public class UserResponse
{
    public void GetMenuSelection()
    {
        string? response = Console.ReadLine();

        if (!Int32.TryParse(response, out int parsedResult))
        {
            Console.WriteLine("Input is not a valid integer. Please try again.");
        }

        else if (!Enum.IsDefined(typeof(Mappings.MenuOption), parsedResult))
        {
            Console.WriteLine("Invalid selection. Your selection may be out of bounds.");
        }

        var selectedMenuOption = Mappings.MenuMap[parsedResult];

        // get question and answer, 
        QuestionAnswerHelper helper = new QuestionAnswerHelper(selectedMenuOption);
        MenuDisplay.ShowUserQuestion(helper.QuestionAnswerInstance.Question);

        // ask question, 

        // and judge answer

        // mark as win or loss
    }

    public void GetAnswerResponse()
    {
        string? response = Console.ReadLine();
    }
}
