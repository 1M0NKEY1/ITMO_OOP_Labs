namespace Itmo.ObjectOrientedProgramming.Lab1;

public abstract class Hull
{
    public int HullDefencePoint { get; set; }
    public bool HullDestroyed { get; set; }

    public abstract int Damage(int countOfObstacles, int classOfObstacles);

    public bool Defence()
    {
        if (HullDefencePoint <= 0 || HullDestroyed)
        {
            HullDestroyed = true;
            HullDefencePoint = 0;
            throw new CustomExceptions("Hull destroyed", "false");
        }

        return true;
    }
}