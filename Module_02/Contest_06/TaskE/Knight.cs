using System;
using System.IO;

public class Knight : LegendaryHuman
{
    public int Equiments { get; set; }
    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        if (equipment.Length <=0)
        {
            throw new ArgumentException("Not enough equipment.");
        }
        Name = name;
        HealthPoints = healthPoints;
        Power = power;
        Equiments = equipment.Length;
    }
    public override string ToString()
    {
        return $"{GetType()} {Name} with HP {HealthPoints}";
    }
    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.WriteLine($"{ToString()} attacked {enemy}.");
            enemy.HealthPoints -= (Power + (Equiments * 10));
            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine($"{enemy} is dead.");
            }
        }
    }
}