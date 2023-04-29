public class CatPriestFactory : ICatFactory
{
    public ICat CreateCat()
    {
        return new CatPriest();
    }
}