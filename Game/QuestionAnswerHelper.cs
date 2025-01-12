using MathConsoleGame.Globals;
using MathConsoleGame.Game.Arithmatic;
using MathConsoleGame.Interfaces;


public class QuestionAnswerHelper
{
    public IArithmatic QuestionAnswerInstance { get; set; }
    public QuestionAnswerHelper(Mappings.MenuOption selection)
    {
        QuestionAnswerInstance = CreateInstance(selection);
    }

    private IArithmatic CreateInstance(Mappings.MenuOption selection)
    {
        return selection switch
        {
            Mappings.MenuOption.Addition => new Addition(),
            Mappings.MenuOption.Multiplication => new Multiplication(),
            Mappings.MenuOption.Division => new Division(),
            Mappings.MenuOption.Subtraction => new Subtraction(),
            _ => throw new ArgumentException("Invalid selection")
        };
    }
}
