namespace MathConsoleGame.Game.Arithmatic;
using MathConsoleGame.Interfaces;

public class Division : ArithmaticBase, IArithmatic
{
    public override void QuestionGenerator()
    {
        // how can I make sure that a / b == an integer?
        // take a number and multiply it, then set var a, b, and answer with that. 
        // because a * b = a number wijth no decimal

        var firstTempNum = _rand.Next(1, 50);
        var secondTempNum = _rand.Next(1, 50);
        var tempResult = firstTempNum * secondTempNum;

        var a = tempResult;
        var b = secondTempNum;
        var result = firstTempNum;

        Question = $"{a} {symbol} {b}";
        Answer = PerformOperation(symbol, a, b);
    }
}
