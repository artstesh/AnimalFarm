namespace Test_2.Tools
{
  public  class MassConverter
    {
        public static double ConvertKilo(int kilos, string type)
        {
            switch (type)
            {
                case "kg": return kilos;
                case "g": return kilos * 1000; 
                case "lb": return kilos * 2.205;
                default: return kilos / 6.35;
            }
        }
    }
}
