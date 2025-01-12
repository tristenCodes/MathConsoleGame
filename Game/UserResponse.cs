namespace MathConsoleGame.Game;
using MathConsoleGame.Globals;

public static class UserResponse
{
    public static Mappings.MenuOption GetMenuSelection()
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
        return selectedMenuOption;
    }

    public static int GetUserAnswer()
    {
        bool isParsable = false;
        int answer = 0;

        while (!isParsable)
        {
            string? response = Console.ReadLine();

            isParsable = Int32.TryParse(response, out int parsedResult);

            if (isParsable) answer = parsedResult;
            else Console.WriteLine("Invalid entry. Remember, it must be an integer");
        }

        return answer;

    }
}
