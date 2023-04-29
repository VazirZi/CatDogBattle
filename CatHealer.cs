public sealed class CatHealer : ICat, IHealing, IHaveProtection
{
    public CatHealer()
    {
        Health = 300;
        Mana = 500;
    }
    public int Health { get; private set;}

    public int MaxHealth => 400;

    public int Mana { get; private set;}

    public int Protection => 75;

    public void GetDamage()
    {
        Console.WriteLine("Принимаю урон.");
    }

    public void Healing()
    {
        Console.WriteLine("Произвожу лечение.");
    }
}