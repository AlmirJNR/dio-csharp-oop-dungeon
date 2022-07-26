namespace DIODungeon.Models.Classes;

class Warrior : Character
{
    private double _healthMultiplier = 2.0;
    private double _staminaMultiplier = 2.0;
    private double _manaMultiplier = 0.25;
    private double _defenseMultiplier = 2.0;
    private double _attackMultiplier = 2.0;

    public Warrior(string name) : base(name)
    {
        this.Health *= _healthMultiplier;
        this.Stamina *= _staminaMultiplier;
        this.Mana *= _manaMultiplier;
        this.Defense *= _defenseMultiplier;
        this.Attack *= _attackMultiplier;
    }

    public override void UseAbilityOnTarget(Character target) {
        if (target.Health > 0)
        {
            target.Health -= (this.Attack - target.Defense);
        }
    }

    public override void UseAreaAbility(List<Character> targets) { }
}
