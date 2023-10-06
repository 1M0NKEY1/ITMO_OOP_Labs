namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Deflectors;

public abstract class Deflector
{
    public int DeflectorDefencePoint { get; set; }
    public int PhotonDeflectorDefencePoint { get; set; }
    public bool DestroyedDeflector { get; set; }
    public bool Emitter { get; set; }

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