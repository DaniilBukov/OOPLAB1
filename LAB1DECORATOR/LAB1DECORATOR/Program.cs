namespace LAB1DECORATOR
{
    class Program
    {
        public static void Main(string[] args)
        {
            Time time1 = new EUTime();
            Console.WriteLine(time1.GetTime());
            USTime time2 = new USTime();
            time1 = new DecoratorUS(time2);
            time1 = new TimeAlert(time2);
            Console.WriteLine(time1.GetTime());

        }
    }
}