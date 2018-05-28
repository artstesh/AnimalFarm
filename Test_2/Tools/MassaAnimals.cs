using Test_2.Models;

namespace Test_2.Tools
{
    public static class MassaAnimals
    {
        static double m;

        public static string[] ListUnitMass()
        {
            return new[] { "kg", "g", "lb", "st" };
        }
        public static string MassaView(Animals SelectedAnimal, object unit)
        {
            if (SelectedAnimal != null)
            {
                switch (unit)
                {
                    case "kg": m = SelectedAnimal.massa; break;
                    case "g": m = SelectedAnimal.massa * 1000; break;
                    case "lb": m = SelectedAnimal.massa * 2.205; break;
                    case "st": m = SelectedAnimal.massa / 6.35; break;
                    case null: return "*** Не выбраны единицы веса ***";
                }
                return SelectedAnimal.name + " " + "весит" + " " + m + " " + unit;
            }
            else return null;

        }
        public static string MassaCompare(Animals Animal_1, Animals Animal_2)
        {
            if (Animal_1 != null && Animal_2 != null)
            {
                if (Animal_1.massa > Animal_2.massa) return Animal_1.name + " весит больше, чем " + Animal_2.name;
                if (Animal_1.massa < Animal_2.massa) return Animal_1.name + " весит меньше, чем " + Animal_2.name;
                return "животные весят одинаково";
            }
            else return "*** выбери 2-х животных для сравнения ***";
        }

    }
}
