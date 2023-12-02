using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public class DeflectorClassThree : Deflector
{
    private const int PhotonPoints = 3;
    private const int DefencePoints = 40;
    private const int ClassThreeRate = 4;

    public DeflectorClassThree()
    {
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
                DeflectorDefencePoint -= ClassThreeRate * countOfObstacles;
                break;
            case SpaceWhales:
                DeflectorDefencePoint -= countOfObstacles;
                break;
            case Flashes:
                PhotonDeflectorDefencePoint -= countOfObstacles;
                break;
        }
    }
}