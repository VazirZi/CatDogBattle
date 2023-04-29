public sealed class CatWarriorFactory : ICatFactory
{
    public ICat CreateCat()
    {
        return new CatWarrior();
    }
}