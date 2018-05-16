using Test_2.Models;

namespace Test_2.Tools
{
   public class AnimalFactory
    {
        public static Animal Create(string name)
        {
            switch (name)
            {
                case "Слон": return new Elephant();
                case "Заяц": return new hare();
                default: return new bear();
            }
        }

        public static string[] GetAnimalNames()
        {
            return new [] {"Слон", "Заяц", "Медведь"};
        }
    }
}
