namespace MathConsoleGame.Game.Arithmatic;

using MathConsoleGame.Globals;
using MathConsoleGame.Interfaces;

public class Multiplication : ArithmaticBase, IArithmatic
{
    public Multiplication()
    {
        this.QuestionType = Mappings.MenuOption.Multiplication;
        this.GenerateQuestionAnswer();
    }
    public override Mappings.MenuOption QuestionType
    {
        get { return base.QuestionType; }
        set { base.QuestionType = value; }
    }
}
