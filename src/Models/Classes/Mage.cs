namespace DIODungeon.Models.Classes;

class Mage : Character
{
    private double _healthMultiplier = 1.0;
    private double _staminaMultiplier = 0.75;
    private double _manaMultiplier = 2.0;
    private double _defenseMultiplier = 0.75;
    private double _attackMultiplier = 3.0;

    public Mage(string name) : base(name)
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