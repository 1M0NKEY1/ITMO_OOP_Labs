namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class Flashes : Obstacles
{
    private int Flash { get; set; }

    public override void SetNumOfObstacle()
    {
        Flash = 4;
    }

    public override int GetNumOfObstacle()
    {
        SetNumOfObstacle();
        return Flash;
    }
}