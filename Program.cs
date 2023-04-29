namespace MyApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
	        Console.Clear();

            ICatFactory[] catFactories = { new CatWarriorFactory(), new CatPalladinFactory(), new CatHealerFactory(), new CatPriestFactory()};

            ICat[] catCommand = new ICat[5];
            
            Random rand = new Random();

            int j = 0;
            int i = 0;

            for (; i < catCommand.Length; i++)
            {
                j = rand.Next(0, 4);
                
                catCommand[i] = catFactories[j].CreateCat();

                Console.WriteLine(catCommand[i]);
            }
        }
    }
}