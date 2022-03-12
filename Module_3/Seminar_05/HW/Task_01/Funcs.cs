using System;

namespace Task_01
{
    public class F : IFunction
    {
        private Func<double, double> calculate;

        public F(Func<double, double> f)
            => calculate = f;
        
        public double Function(double x)
            => calculate(x);
    }

    public class G
    {
        private F g;
        private F f;

        public G(F g, F f)
            => (this.g, this.f) = (g, f);

        public double GF(double x0)
            => g.Function(f.Function(x0));
    }
}