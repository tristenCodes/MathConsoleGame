using MathConsoleGame.Globals;
using MathConsoleGame.Game.Arithmatic;
using MathConsoleGame.Interfaces;


public class QuestionAnswerHelper
{
    public QuestionAnswerHelper(Mappings.MenuOption selection)
    {
        QuestionAnswerInstance = InstanceMap[selection];
    }

    public IArithmatic QuestionAnswerInstance { get; set; }

    private Dictionary<Mappings.MenuOption, IArithmatic> InstanceMap = new()
    {
      {Mappings.MenuOption.Addition, new Addition()},
      {Mappings.MenuOption.Subtraction, new Subtraction()},
      {Mappings.MenuOption.Multiplication, new Multiplication()},
      {Mappings.MenuOption.Division, new Division()}
    };
}
