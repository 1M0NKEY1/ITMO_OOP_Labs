namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir.Entities;

public class TopicName : ITopicName
{
    public TopicName(string name)
    {
        Name = name;
    }

    private string Name { get; }

    public string GetTopicName()
    {
        return Name;
    }
}