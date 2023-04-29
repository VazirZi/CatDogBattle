public sealed class CatPalladinFactory : ICatFactory
{
    public ICat CreateCat()
    {
        return new CatPalladin();
    }
}