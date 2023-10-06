namespace Itmo.ObjectOrientedProgramming.Lab1;

public abstract class Hull
{
    public bool HullDestroyed { get; protected set; }
    protected int HullDefencePoint { get; set; }
    public abstract int Damage(int countOfObstacles, int classOfObstacles);

    public bool Defence()
    {
        if (HullDefencePoint > 0 && !HullDestroyed) return true;
        HullDestroyed = true;
        HullDefencePoint = 0;
        throw new CustomExceptions("Hull destroyed", "false");
    }
}