using MathConsoleGame.Globals;
using MathConsoleGame.Game.Arithmatic;
using MathConsoleGame.Interfaces;


public class QuestionAnswerHelper
{
    private IArithmatic Instance;
    public QuestionAnswerHelper(Mappings.MenuOption selection)
    {

    }

    public Dictionary<Mappings.MenuOption, Addition> InstanceMap = new()
    {
      {Mappings.MenuOption.Addition, new Addition()}
    };
}
