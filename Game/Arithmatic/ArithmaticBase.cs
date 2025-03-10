namespace MathConsoleGame.Game.Arithmatic;

using MathConsoleGame.Interfaces;
using MathConsoleGame.Globals;

public abstract class ArithmaticBase : IArithmatic
{
    private protected char symbol;
    private protected Random _rand = new Random();


    public string Question { get; set; } = "";
    public int Answer { get; set; }
    public virtual Mappings.MenuOption QuestionType {get; set;}


    public virtual void GenerateQuestionAnswer()
    {
        var a = _rand.Next(1, 100);
        var b = _rand.Next(1, 100);

        symbol = GetSymbolFromQuestionType(QuestionType);
        Question = $"{a} {symbol} {b}";

        Answer = PerformOperation(symbol, a, b);
    }

    private protected char GetSymbolFromQuestionType(Mappings.MenuOption questionType)
    {
        switch (questionType)
        {
            case Mappings.MenuOption.Addition:
                return '+';

            case Mappings.MenuOption.Subtraction:
                return '-';

            case Mappings.MenuOption.Multiplication:
                return '*';

            case Mappings.MenuOption.Division:
                return '/';

            default:
                return ' ';
        }
    }

    private protected int PerformOperation(char op, int a, int b)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b != 0 ? a / b : throw new DivideByZeroException(),
            ' ' => throw new InvalidOperationException("Unsupported Operation"),
            _ => throw new InvalidOperationException("Unsupported Operation"),
        };
    }
}
