namespace DIODungeon.Models.Enemies;

class Goblin : Character
{
    private double _healthMultiplier = 1;
    private double _staminaMultiplier = 0.5;
    private double _manaMultiplier = 0.1;
    private double _defenseMultiplier = 0.25;
    private double _attackMultiplier = 0.75;

    public Goblin(string name = "Goblin") : base(name)
    {
        this.Name += $" Lv.{this.Level}";
        this.Health *= _healthMultiplier;
        this.Stamina *= _staminaMultiplier;
        this.Mana *= _manaMultiplier;
        this.Defense *= _defenseMultiplier;
        this.Attack *= _attackMultiplier;
    }

    public override void UseAbilityOnTarget(Character target, double bonus = 0.0) { }

    public override void UseAreaAbility(List<Character> targets, double bonus = 0.0) { }
}
