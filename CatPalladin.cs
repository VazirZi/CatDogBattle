public sealed class CatPalladin : ICat, IAttack, IHealing, IHaveDamage, IHaveProtection
{
    public CatPalladin()
    {
        Health = 300;
        Mana = 200;
    }
    public int Health { get; private set;}

    public int MaxHealth => 400;

    public int Mana { get; private set;}

    public int Damage => 80;

    public int Protection => 50;

    public void Attack()
    {
        Console.WriteLine("Атакую.");
    }

    public void GetDamage()
    {
        Console.WriteLine("Принимаю урон.");
    }

    public void Healing()
    {
        Console.WriteLine("Произвожу лечение.");
    }
}