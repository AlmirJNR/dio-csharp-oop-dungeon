namespace DIODungeon.Models;

abstract class Attributes
{
    public double Health { get; set; }
    public double Stamina { get; set; }
    public double Mana { get; set; }
    public double Defense { get; set; }
    public double Attack { get; set; }
    public double CriticalRate { get; set; }
    public double CriticalDamage { get; set; }

    public Attributes
    (
        double health,
        double stamina,
        double mana,
        double defense,
        double attack,
        double criticalRate,
        double criticalDamage
    )
    {
        this.Health = health;
        this.Stamina = stamina;
        this.Mana = mana;
        this.Defense = defense;
        this.Attack = attack;
        this.CriticalRate = criticalRate;
        this.CriticalDamage = criticalDamage;
    }
}
