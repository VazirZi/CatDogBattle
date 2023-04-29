public sealed class CatPriest : ICat, IHealing, IMagicAttack, IHaveDamage, IHaveProtection
{
    public CatPriest()
    {
        Health = 250;
        Mana = 400;
    }
    public int Health { get; private set; }

    public int MaxHealth => 350;

    public int Mana { get; private set; }

    public int Protection => 35;

    public int Damage => 40;

    public void GetDamage()
    {
        Console.WriteLine("Принимаю урон.");
    }

    public void Healing()
    {
        Console.WriteLine("Произвожу лечение.");
    }

    public void MagicAttack()
    {
        Console.WriteLine("Атакую магией.");
    }
}