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

    public override void Damage(int countOfObstacles, IList<Obstacles> obstacle, int iStep)
    {
        switch (obstacle[iStep])
        {
            case Asteroids:
                DeflectorDefencePoint -= countOfObstacles;
                break;
            case Meteorites:
            {
                if (countOfObstacles >= 3)
                {
                    DeflectorDefencePoint = EndDefence;
                    DestroyedDeflector = true;
                }

                DeflectorDefencePoint -= (int)(ClassTwoRate * countOfObstacles);
                break;
            }

            case SpaceWhales when Emitter:
                break;
            case SpaceWhales:
                DeflectorDefencePoint = EndDefence;
                DestroyedDeflector = true;
                break;
            case Flashes:
                PhotonDeflectorDefencePoint -= countOfObstacles;
                break;
        }
    }
}