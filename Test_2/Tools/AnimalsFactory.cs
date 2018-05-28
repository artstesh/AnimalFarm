using Test_2.Models;

namespace Test_2.Tools
{
    public static class AnimalsFactory
    {
        public static string[] ListNamesAnimals()
        {
            return new[] { "Слон", "Заяц", "Медведь" };
        }

        public static Animals CreateAnimals(string name)
        {
            switch (name)
            {
                case "Медведь": return new Bear();
                case "Слон": return new Elephant();
                default: return new Hare();
            }

        }

    }
}
