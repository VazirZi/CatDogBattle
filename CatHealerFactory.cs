public sealed class CatHealerFactory : ICatFactory
{
    public ICat CreateCat()
    {
        return new CatHealer();
    }
}