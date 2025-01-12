namespace MathConsoleGame.Game.Arithmatic;

using MathConsoleGame.Globals;
using MathConsoleGame.Interfaces;

public class Subtraction : ArithmaticBase, IArithmatic
{
    public Subtraction()
    {
        this.QuestionType = Mappings.MenuOption.Subtraction;
        this.GenerateQuestionAnswer();
    }
    public override Mappings.MenuOption QuestionType
    {
        get { return base.QuestionType; }
        set { base.QuestionType = value; }
    }
}
