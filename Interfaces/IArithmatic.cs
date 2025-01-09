namespace MathConsoleGame.Interfaces;

public interface IArithmatic
{
    public void QuestionGenerator();
    string Question
    {
        get; set;
    }

    int Answer
    {
        get; set;
    }
}
