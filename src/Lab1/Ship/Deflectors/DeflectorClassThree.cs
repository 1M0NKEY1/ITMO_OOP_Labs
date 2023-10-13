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

    public override void Damage(int countOfObstacles, IList<object> obstacle)
    {
        if (obstacle is Asteroids)
        {
            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (obstacle is Meteorites)
        {
            DeflectorDefencePoint -= ClassThreeRate * countOfObstacles;
        }
        else if (obstacle is SpaceWhales)
        {
            DeflectorDefencePoint -= countOfObstacles;
        }
        else if (obstacle is Flashes)
        {
            PhotonDeflectorDefencePoint -= countOfObstacles;
        }
    }
}