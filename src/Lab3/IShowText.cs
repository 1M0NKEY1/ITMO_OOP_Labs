namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface IShowText : IRenderText
{
    void DrawText(string text);
    void ClearOutput();
}