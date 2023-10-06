namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public abstract class Deflector
{
    public bool PhotonDeflectorDefencePoint { get; set; }
    public bool DestroyedDeflector { get; protected set; }
    public bool Emitter { get; set; }
    protected int DeflectorDefencePoint { get; set; }

    public abstract int Damage(int countOfObstacles, int classOfObstacles);
    public bool DefenceTurnOff()
    {
        if (DeflectorDefencePoint <= 0)
        {
            DestroyedDeflector = true;
            DeflectorDefencePoint = 0;
            return false;
        }

        DestroyedDeflector = false;
        return true;
    }
}