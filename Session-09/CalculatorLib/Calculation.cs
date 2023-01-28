namespace CalculatorLib
{

    public class Calculation
    {


        public class Addition
        {

            public decimal Do(decimal? x, decimal? y)
            {
                decimal res = 0;
                if (x != null && y != null)
                {

                    res = x.Value + y.Value;
                }
                return res;
            }
        }
        public class Subtraction
        {
            public decimal Do(decimal? x, decimal? y)
            {
                decimal res = 0;
                if (x != null && y != null)
                {
                    res = x.Value - y.Value;
                }
                return res;
            }
        }

        public class Multiplication
        {
            public decimal Do(decimal? x, decimal? y)
            {
                decimal res = 0;
                if (x != null && y != null)
                {
                    res = x.Value * y.Value;
                }
                return res;
            }

        }
        public class Division
        {
            public decimal Do(decimal? x, decimal? y)
            {
                decimal res = 0;
                if (x != null && y != null)
                {
                    res = x.Value / y.Value;
                }
                return res;
            }
        }
        public class RaiseToPower
        {
            public decimal Do(decimal? x, decimal? y)
            {
                decimal res = 0;
                if (x.HasValue && y.HasValue)
                {
                    res = (decimal)Math.Pow((double)x, (double)y);
                }
                return res;

            }
        }
        public class SquareRoot
        {

            public decimal Do(decimal? x)
            {
                decimal result = 0;
                if (x.HasValue)
                {
                    double doubleVal = (double)x.Value;
                    double doubleResult = Math.Sqrt(doubleVal);
                    result = (decimal)doubleResult;
                }
                return result;
            }

        }
    }

}

