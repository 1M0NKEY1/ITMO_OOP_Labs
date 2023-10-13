using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public abstract class Deflector
{
    public bool DestroyedDeflector { get; protected set; }
    public bool Photon { get; set; }
    public int PhotonDeflectorDefencePoint { get; protected set; }
    protected bool Emitter { get; init; }
    protected int DeflectorDefencePoint { get; set; }

    public abstract void Damage(int countOfObstacles, IList<object> obstacle);
    public bool DefenceTurnOff()
    {
        if (DeflectorDefencePoint < 0)
        {
            DestroyedDeflector = true;
            return true;
        }

        DestroyedDeflector = false;
        return false;
    }
}