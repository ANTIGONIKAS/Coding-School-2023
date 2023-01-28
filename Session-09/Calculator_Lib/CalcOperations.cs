namespace Calculator_Lib
{
    public abstract class CalcOperations
    {
        public decimal x { get; set; }
        public decimal y { get; set; }
        public decimal res { get; set; }
        public abstract string Calc(decimal x, decimal y);



        public CalcOperations()
        {

        }


        public class Addition : CalcOperations
        {
            public override string Calc(decimal x, decimal y)
            {
                decimal res = 0;
                res = x + y;

                return res.ToString("0.000");
            }
        }

        public class Subtraction : CalcOperations
        {
            public override string Calc(decimal x, decimal y)
            {
                decimal res = 0;
                res = x - y;
                return res.ToString("0.000");
            }

        }


        public class Multiplication : CalcOperations
        {
            public override string Calc(decimal x, decimal y)
            {
                decimal res = 0;
                res = x * y;
                return res.ToString("0.000");
            }
        }
        public class Division : CalcOperations
        {
            public override string Calc(decimal x, decimal y)
            {
                decimal res = 0;
                res = x / y;
                return res.ToString("0.000");

            }
        }
        public class RaiseToPower : CalcOperations
        {
            public override string Calc(decimal x, decimal y)
            {
                decimal res = 0;

                res = (decimal)Math.Pow((double)x, (double)y);
                return res.ToString("0.000");
            }

        }
        public class SquareRoot : CalcOperations
        {
            public override string Calc(decimal x, decimal y)
            {
                decimal res = 0;
                res = (decimal)Math.Sqrt((double)x * (double)y);
                return res.ToString("0.000");
            }
        }
    }
}
