namespace MathConsoleGame.Game;

public class MenuDisplay
{

    public void PrintMenuOptions()
    {
        foreach (var keyValuePair in _menuOptions)
        {
            Console.WriteLine($"{keyValuePair.Key}. {keyValuePair.Value}");
        }
    }

}
