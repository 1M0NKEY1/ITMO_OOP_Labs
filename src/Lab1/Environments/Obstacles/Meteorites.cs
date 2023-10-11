namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class Meteorites : Obstacles
{
    private int Meteorite { get; set; }

    public override void SetNumOfObstacle()
    {
        Meteorite = 2;
    }

    public override int GetNumOfObstacle()
    {
        SetNumOfObstacle();
        return Meteorite;
    }
}