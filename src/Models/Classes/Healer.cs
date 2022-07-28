namespace DIODungeon.Models.Classes;

class Healer : Character
{
    private double _healthMultiplier = 1.25;
    private double _staminaMultiplier = 1.0;
    private double _manaMultiplier = 1.5;
    private double _defenseMultiplier = 1.25;
    private double _attackMultiplier = 1.0;

    public Healer(string name) : base(name)
    {
        this.Health *= _healthMultiplier;
        this.Stamina *= _staminaMultiplier;
        this.Mana *= _manaMultiplier;
        this.Defense *= _defenseMultiplier;
        this.Attack *= _attackMultiplier;
    }

    public override void UseAbilityOnTarget(Character target, double bonus = 0.0) { }

    public override void UseAreaAbility(List<Character> targets, double bonus = 0.0) { }
}