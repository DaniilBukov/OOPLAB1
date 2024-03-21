namespace Rational
{
    public class Rational
    {

        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }

        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            private set { denominator = value; }
        }


        public Rational(int N, int D)
        {
            if (D == 0) throw new ArgumentException(nameof(denominator), "DIVIDE_BY_ZERO_EXCEPTION");
            numerator = N;
            denominator = D;

            Simplify();
        }
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }
        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static Rational operator -(Rational a)
        {
            return new Rational(-a.numerator, a.denominator);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.numerator * b.numerator, a.denominator * b.denominator);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            return new Rational(a.numerator * b.denominator, a.denominator * b.numerator);
        }
        public static bool operator ==(Rational a, Rational b)
        {
            if (a.numerator == b.numerator && a.denominator == b.denominator) return true;
            else return false;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            if (a.numerator == b.numerator && a.denominator == b.denominator) return false;
            else return true;
        }


        public static bool operator <(Rational a, Rational b)
        {
            if (a.numerator * b.denominator < b.numerator * a.denominator) return true;
            else return false;
        }
        public static bool operator >(Rational a, Rational b)
        {
            if (a.numerator * b.denominator > b.numerator * a.denominator) return true;
            else return false;
        }
        public static bool operator <=(Rational a, Rational b)
        {
            if (a.numerator * b.denominator <= b.numerator * a.denominator) return true;
            else return false;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            if (a.numerator * b.denominator >= b.numerator * a.denominator) return true;
            else return false;
        }

        public override string ToString()
        {
            string S = "";
            if (denominator == 1)
            {
                S = numerator.ToString();
            }
            else if (denominator != 0)
            {
                S = numerator.ToString() + "/" + denominator.ToString();
            }
            else
            {
                S = "ERROR_DIVISION_BY_ZERO";
            }
            return S;
        }
        private int GCD()
        {
            int a = Math.Abs(numerator);
            int b = Math.Abs(denominator);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }

            return a;
        }
        private void Simplify()
        {
            if (denominator != 0 && numerator != 0)
            {
                int gcd = GCD();
                numerator /= gcd;
                denominator /= gcd;
                if (denominator < 0)
                {
                    numerator = -numerator;
                    denominator = -denominator;
                }

            }
            else if (numerator == 0 && denominator != 0)
            {
                denominator = 1;
            }
        }
    }
}