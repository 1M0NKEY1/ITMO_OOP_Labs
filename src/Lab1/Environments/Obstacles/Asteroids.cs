namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class Asteroids : Obstacles
{
    private int Asteroid { get; set; }

    public override void SetNumOfObstacle()
    {
        Asteroid = 1;
    }

    public override int GetNumOfObstacle()
    {
        SetNumOfObstacle();
        return Asteroid;
    }
}