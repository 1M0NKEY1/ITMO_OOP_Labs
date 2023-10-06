using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorsClassPhoton : Deflector
{
    public DeflectorsClassPhoton()
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = 3;
    }

    public override int Damage(int countOfObstacles, int classOfObstacles)
    {
        if (classOfObstacles is not (int)Obstacles.Flashes) return DeflectorDefencePoint;
        DeflectorDefencePoint -= countOfObstacles;
        return DeflectorDefencePoint;
    }
}