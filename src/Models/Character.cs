using DIODungeon.Constants;

namespace DIODungeon.Models;

abstract class Character : Attributes
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }

    public Character
    (
        string name,
        int level = CharacterConstants.INITIAL_LEVEL,
        double health = CharacterConstants.INITIAL_HEALTH,
        double stamina = CharacterConstants.INITIAL_STAMINA,
        double mana = CharacterConstants.INITIAL_MANA,
        double defense = CharacterConstants.INITIAL_DEFENSE,
        double attack = CharacterConstants.INITIAL_ATTACK,
        double criticalRate = CharacterConstants.INITIAL_CRITICAL_RATE,
        double criticalDamage = CharacterConstants.INITIAL_CRITICAL_DAMAGE
    ) : base
        (
            health,
            stamina,
            mana,
            defense,
            attack,
            criticalRate,
            criticalDamage
        )
    {
        this.Name = name;
        this.Level = level;
    }

    public override string ToString() => $"[{this.GetType().Name}]: {this.Name}\n[Health]: {this.Health}\n";

    public void LevelUp()
    {
        this.Level += 1;
        Console.WriteLine($"{this.Name} has Leveled Up!");
    }

    public void DamageTarget(Character target, double bonus = 0.0)
    {
        if (target.Health > 0)
        {   
            var attackDamage = (this.Attack + bonus) - target.Defense;
            target.Health -= attackDamage;

            Console.WriteLine($"{this.Name} attacked {target.Name}");
            Console.WriteLine($"{target.Name} lost {attackDamage} health");
            Console.WriteLine($"{target.Name} remaining health is {target.Health}");
        }
    }

    public abstract void UseAbilityOnTarget(Character target);

    public abstract void UseAreaAbility(List<Character> targets);
}
