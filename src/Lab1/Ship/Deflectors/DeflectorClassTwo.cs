using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassTwo : Deflector
{
    private const int PhotonPoints = 3;
    private const int DefencePoints = 10;
    private const double ClassTwoRate = 3.33;
    private const int EndDefence = -1;

    public DeflectorClassTwo(bool emitter)
    {
        Emitter = emitter;
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
            if (countOfObstacles >= 3)
            {
                DeflectorDefencePoint = EndDefence;
                DestroyedDeflector = true;
            }

            DeflectorDefencePoint -= (int)(ClassTwoRate * countOfObstacles);
        }
        else if (obstacle is SpaceWhales)
        {
            if (Emitter)
            {
                return;
            }

            DeflectorDefencePoint = EndDefence;
            DestroyedDeflector = true;
        }
        else if (obstacle is Flashes)
        {
            PhotonDeflectorDefencePoint -= countOfObstacles;
        }
    }
}