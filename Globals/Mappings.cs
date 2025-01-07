namespace MathConsoleGame.Globals;

public static class Mappings
{
    public enum MenuOption
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        GameHistory = 5,
    }

    public static Dictionary<int, MenuOption> MenuMap = new(){
      {1, MenuOption.Addition},
      {2, MenuOption.Subtraction},
      {3, MenuOption.Multiplication},
      {4, MenuOption.Division},
      {5, MenuOption.GameHistory},
    };


}

