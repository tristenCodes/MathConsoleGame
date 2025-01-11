namespace MathConsoleGame.Interfaces;

public interface IArithmatic
{
    public void GenerateQuestionAnswer();
    string Question
    {
        get; set;
    }

    int Answer
    {
        get; set;
    }
}
