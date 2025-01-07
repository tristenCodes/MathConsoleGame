namespace MathConsoleGame.Shared;

public static class Mappings
{
    private enum MenuOptions
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        GameHistory = 5,
    }

    private static Dictionary<int, MenuOptions> _menuOptions = new(){
      {1, MenuOptions.Addition},
      {2, MenuOptions.Subtraction},
      {3, MenuOptions.Multiplication},
      {4, MenuOptions.Division},
      {4, MenuOptions.GameHistory},
    };

    static Dictionary<int, MenuOptions> GetMenuOptions()
    {
        return _menuOptions;
    }


}
