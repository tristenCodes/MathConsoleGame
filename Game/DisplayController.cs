using MathConsoleGame.Globals;
namespace MathConsoleGame.Game;

public static class DisplayController
{
    public static void PrintMenuOptions()
    {
        foreach (var keyValuePair in Mappings.MenuMap)
        {
            Console.WriteLine($"{keyValuePair.Key}. {keyValuePair.Value}");
        }
    }

    public static void PrintUserQuestion(string question)
    {
        Console.WriteLine($"Question: {question}");
    }

    internal static void PrintGameScore(Dictionary<int, string> score)
    {
        Console.Clear();
        foreach (var item in score)
        {
            Console.WriteLine($"{item.Key}. {item.Value}");
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}
