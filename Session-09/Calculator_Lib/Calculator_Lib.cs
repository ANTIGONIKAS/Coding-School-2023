namespace Calculator_Lib
{
    public class Addition
    {
        public decimal Do(decimal? x, decimal? y)
        {

            decimal res = 0;

            if (x != null && y != null)
            {
                ret = x.Value + y.Value;
            }

            return res;
        }

    }
}
}