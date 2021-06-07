using System;
using System.IO;

public class Wizard : LegendaryHuman
{
    public int Rank { get; set; }
    public string RankString { get; set; }
    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints,
        power)
    {
        if (rank == "Neophyte") { Rank = 1; RankString = rank; }
        else if (rank == "Adept") { Rank = 2; RankString = rank; }
        else if (rank == "Charmer") { Rank = 3; RankString = rank; }
        else if (rank == "Sorcerer") { Rank = 4; RankString = rank; }
        else if (rank == "Master") { Rank = 5; RankString = rank; }
        else if (rank == "Archmage") { Rank = 6; RankString = rank; }
        else { throw new ArgumentException("Invalid wizard rank."); }
        Name = name;
        HealthPoints = healthPoints;
        Power = power;
    }
    public override string ToString()
    {
        return $"{RankString} Wizard {Name} with HP {HealthPoints}";
    }
    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.WriteLine($"{ToString()} attacked {enemy}.");
            enemy.HealthPoints -= (Power * (int)(Math.Pow((int)Rank, 1.5)) + HealthPoints / 10);

            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine($"{enemy} is dead.");
            }
        }
    }
}