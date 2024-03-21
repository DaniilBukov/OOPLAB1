using System.Globalization;
using System.Text;

namespace LAB1DECORATOR
{
    abstract class Time
    {
        public CultureInfo Culture;
        public abstract string GetTime();
        public Time(CultureInfo Culture)
        {
            this.Culture = Culture;
        }
    }
    class EUTime : Time
    {
        public EUTime() : base(new CultureInfo("es-ES", false)) { }
        public override string GetTime()
        {
            return DateTime.Now.ToString(Culture);
        }
    }
    class USTime : Time
    {
        public USTime() : base(new CultureInfo("us-US", false)) { }
        public override string GetTime()
        {
            return DateTime.Now.ToString(Culture);
        }
    }

    abstract class Decorator : Time
    {
        protected Time time;
        public Decorator(Time time) : base(time.Culture)
        {
            this.time = time;
        }
        public override string GetTime()
        {
            return time.GetTime();
        }
    }
    class DecoratorEU : Decorator
    {
        public DecoratorEU(EUTime time) : base(time) { }
        public override string GetTime()
        {

            StringBuilder str = new StringBuilder("Date and time now in EU-style: ");
            str.Append(DateTime.Now.ToString(Culture));
            return str.ToString();
        }
    }
    class DecoratorUS : Decorator
    {
        public DecoratorUS(USTime time) : base(time) { }
        public override string GetTime()
        {

            StringBuilder str = new StringBuilder("Date and time now in US-style: ");
            str.Append(DateTime.Now.ToString(Culture));
            return str.ToString();
        }
    }
    class TimeAlert : Decorator
    {
        public TimeAlert(Time time) : base(time) { }
        public override string GetTime()
        {
            StringBuilder str = new StringBuilder(time.GetTime());
            str.Append("!!!");
            return str.ToString();
        }
    }


}

