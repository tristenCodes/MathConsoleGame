namespace MathConsoleGame.Game.Arithmatic;

using MathConsoleGame.Globals;
using MathConsoleGame.Interfaces;

public class Addition : ArithmaticBase, IArithmatic
{
    public Addition() {
        this.QuestionType = Mappings.MenuOption.Addition;
        this.GenerateQuestionAnswer();
    }
    public override Mappings.MenuOption QuestionType
    {
        get { return base.QuestionType; }
        set { base.QuestionType = value; }
    }
}
