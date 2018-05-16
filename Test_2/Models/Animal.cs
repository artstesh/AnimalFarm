namespace Test_2.Models
{
    public abstract class Animal
    {
        public string name;
        public int massa;
        public double massaGen;
        public string unit;

        public string view ()
        {
            return name + " " + "весит" + " "+ massaGen + " " + unit;  
        }
    }
}
