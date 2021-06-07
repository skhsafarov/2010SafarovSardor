
using System;

public class Sheep
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sound { get; set; }
    public Sheep(int id, string name, string sound)
    {
        Id = id;
        Name = name;
        Sound = sound;
    }
    public override string ToString()
    {
        return $"[{Id}-{Name}]: {Sound}...{Sound}";
    }
}
