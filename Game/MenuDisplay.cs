using MathConsoleGame.Globals;
namespace MathConsoleGame.Game;

public static class MenuDisplay
{
    public static void PrintMenuOptions()
    {
        foreach (var keyValuePair in Mappings.MenuMap)
        {
            Console.WriteLine($"{keyValuePair.Key}. {keyValuePair.Value}");
        }
    }

    public static void ShowUserQuestion(string question)
    {
        Console.WriteLine($"Question: {question}");
    }

}
