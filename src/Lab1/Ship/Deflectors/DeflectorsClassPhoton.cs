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
        if (classOfObstacles is (int)Obstacles.Flashes)
        {
            DeflectorDefencePoint -= countOfObstacles;
            return DeflectorDefencePoint;
        }

        return DeflectorDefencePoint;
    }
}