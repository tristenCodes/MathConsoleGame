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


        // if valid response, process with question generator to get question and answer, ask them for answer
    }

    public void GetAnswer()
    {
        string? response = Console.ReadLine();
    }
}
