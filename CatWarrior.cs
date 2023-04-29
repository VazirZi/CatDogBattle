public sealed class CatWarrior : ICat, IHaveDamage, IHaveProtection, IAttack
{
    public CatWarrior()
    {
        Health = 450;
    }
    public int Health { get; private set; }

    public int MaxHealth => 550;

    public int Damage => 150;

    public int Protection => 100;
    
    public void Attack()
    {
        Console.WriteLine("Атакую.");
    }

    public void GetDamage()
    {
        Console.WriteLine("Принимаю урон.");
    }
}