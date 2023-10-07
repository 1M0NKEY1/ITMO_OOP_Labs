namespace Itmo.ObjectOrientedProgramming.Lab1;

public abstract class Environment
{
    public int ClassOfObstacle1 { get; protected init; }
    public int ClassOfObstacle2 { get; protected init; }
    protected int CountOfAsteroids { get; set; }
    protected int CountOfMeteorites { get; set; }
    protected int CountsOfSpaceWhales { get; set; }
    protected int CountOfFlashes { get; set; }

    public abstract bool Conditions(int engineType);
    public abstract bool ExtraConditions(int engineJumpType);
}