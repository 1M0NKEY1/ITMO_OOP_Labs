using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassOne : Deflector
{
    private const int PhotonPoints = 3;
    private const int DefencePoints = 2;
    private const int ClassOneRate = 2;
    private const int EndDefence = -1;

    public DeflectorClassOne()
    {
        DestroyedDeflector = false;
        DeflectorDefencePoint = DefencePoints;
        if (Photon)
        {
            PhotonDeflectorDefencePoint = PhotonPoints;
        }
    }

    public override void Damage(int countOfObstacles, IList<object> obstacle)
    {
        if (obstacle is Asteroids)
        {
            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (obstacle is Meteorites)
        {
            DeflectorDefencePoint -= ClassOneRate * countOfObstacles;
        }
        else if (obstacle is SpaceWhales)
        {
            DestroyedDeflector = true;
            DeflectorDefencePoint = EndDefence;
        }
        else if (obstacle is Flashes)
        {
            PhotonDeflectorDefencePoint -= countOfObstacles;
        }
    }
}