namespace Rational.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]



        [TestCase(2, 3, "2/3")]
        [TestCase(3, 3, "1")]
        [TestCase(15, 3, "5")]
        [TestCase(-5, -3, "5/3")]
        [TestCase(-18, -3, "6")]
        [TestCase(18, -4, "-9/2")]

        public void ToStringTest(int n1, int d1, string str)
        {
            Rational a = new Rational(n1, d1);

            Assert.That(a.ToString, Is.EqualTo(str));
        }

        [TestCase(2, 3, 1, 3, "1")]
        [TestCase(3, 3, 1, 3, "4/3")]
        [TestCase(-2, 3, 1, 3, "-1/3")]
        [TestCase(-5, 3, 2, 3, "-1")]
        public void OperatorPlusTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 + r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "1/3")]
        [TestCase(3, 3, 1, 3, "2/3")]
        [TestCase(-2, 3, 1, 3, "-1")]
        [TestCase(-5, 3, 2, 3, "-7/3")]
        public void OperatorbMinusTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 - r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, "-2/3")]
        [TestCase(3, 3, "-1")]
        [TestCase(-2, 3, "2/3")]
        [TestCase(-5, 3, "5/3")]
        public void OperatoruMinusTest(int n1, int d1, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            string str2;

            str2 = (-r1).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "2/9")]
        [TestCase(3, 3, 1, 3, "1/3")]
        [TestCase(-2, 3, 1, 3, "-2/9")]
        [TestCase(-5, 3, 2, 3, "-10/9")]
        public void OperatorMulTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 * r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "2")]
        [TestCase(3, 3, 1, 3, "3")]
        [TestCase(-2, 3, 1, 3, "-2")]
        [TestCase(-5, 3, 2, 3, "-5/2")]
        public void OperatorSlashTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 / r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "False")]
        [TestCase(3, 3, 1, 3, "False")]
        [TestCase(-2, 3, 1, 3, "False")]
        [TestCase(-5, 3, 2, 3, "False")]
        [TestCase(-2, 3, 1, 3, "False")]
        [TestCase(1, 3, 3, 9, "True")]
        [TestCase(-1, -3, -3, -9, "True")]
        [TestCase(9, 3, 3, 1, "True")]
        [TestCase(25, 100, 1, 4, "True")]
        public void OperatorEqualTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 == r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "True")]
        [TestCase(3, 3, 1, 3, "True")]
        [TestCase(-2, 3, 1, 3, "True")]
        [TestCase(-5, 3, 2, 3, "True")]
        [TestCase(-2, 3, 1, 3, "True")]
        [TestCase(1, 3, 3, 9, "False")]
        [TestCase(-1, -3, -3, -9, "False")]
        [TestCase(9, 3, 3, 1, "False")]
        [TestCase(25, 100, 1, 4, "False")]
        public void OperatornEqualTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 != r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "False")]
        [TestCase(3, 3, 1, 3, "False")]
        [TestCase(-2, 3, 1, 3, "True")]
        [TestCase(-5, 3, 2, 3, "True")]
        [TestCase(-2, 3, 1, 3, "True")]
        [TestCase(1, 3, 3, 9, "False")]
        [TestCase(-1, -3, -3, -9, "False")]
        [TestCase(9, 3, 3, 1, "False")]
        [TestCase(25, 100, 1, 4, "False")]
        public void OperatorLessTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 < r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "True")]
        [TestCase(3, 3, 1, 3, "True")]
        [TestCase(-2, 3, 1, 3, "False")]
        [TestCase(-5, 3, 2, 3, "False")]
        [TestCase(-2, 3, 1, 3, "False")]
        [TestCase(1, 3, 3, 9, "False")]
        [TestCase(-1, -3, -3, -9, "False")]
        [TestCase(9, 3, 3, 1, "False")]
        [TestCase(25, 100, 1, 4, "False")]
        public void OperatorMoreTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 > r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }

        [TestCase(2, 3, 1, 3, "False")]
        [TestCase(3, 3, 1, 3, "False")]
        [TestCase(-2, 3, 1, 3, "True")]
        [TestCase(-5, 3, 2, 3, "True")]
        [TestCase(-2, 3, 1, 3, "True")]
        [TestCase(1, 3, 3, 9, "True")]
        [TestCase(-1, -3, -3, -9, "True")]
        [TestCase(9, 3, 3, 1, "True")]
        [TestCase(25, 100, 1, 4, "True")]
        public void OperatorNOMoreTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 <= r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }
        [TestCase(2, 3, 1, 3, "True")]
        [TestCase(3, 3, 1, 3, "True")]
        [TestCase(-2, 3, 1, 3, "False")]
        [TestCase(-5, 3, 2, 3, "False")]
        [TestCase(-2, 3, 1, 3, "False")]
        [TestCase(1, 3, 3, 9, "True")]
        [TestCase(-1, -3, -3, -9, "True")]
        [TestCase(9, 3, 3, 1, "True")]
        [TestCase(25, 100, 1, 4, "True")]
        public void OperatorNOLessTest(int n1, int d1, int n2, int d2, string str1)
        {
            Rational r1 = new Rational(n1, d1);
            Rational r2 = new Rational(n2, d2);
            string str2;

            str2 = (r1 >= r2).ToString();
            Assert.That(str1, Is.EqualTo(str2));
        }
        [TestCase(1, 0)]
        [TestCase(5, 0)]
        [TestCase(-2, 0)]
        [TestCase(3, 0)]
        [TestCase(-3, 0)]
        [TestCase(0, 0)]
        public void DenominatorZeroTest(int n, int d)
        {
            Assert.Throws<ArgumentException>(() => { new Rational(n, d); });
        }
    }
}