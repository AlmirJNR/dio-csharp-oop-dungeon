using DIODungeon.Models;
using DIODungeon.Models.Classes;
using DIODungeon.Models.Enemies;

var enemy = new Goblin();

var party = new List<Character>
{
    new Warrior("Almir"),
    new Mage("Helton"),
    new Healer("Vitoria"),
};

foreach (var hero in party)
{
    hero.DamageTarget(enemy);
    Console.WriteLine();
}

if (enemy.Health <= 0)
{
    Console.Write("Party members ");

    for (int i = 0; i < party.Count; i++)
    {
        var value = i < party.Count - 1 ? $"{party[i].Name}, " : $"{party[i].Name} ";
        Console.Write(value);
    }

    Console.WriteLine("won the dungeon");
}
else
{
    Console.WriteLine($"Party members lost against {enemy.Name}");
}
