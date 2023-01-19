namespace CalculatorLib
{
    public class Addition
    {
        
    public decimal Do(decimal x,decimal y)
        {
            string s = "1 +1 =";
            return x + y;
        }

        public decimal? Do(decimal? value1, decimal? value2)
        {
            throw new NotImplementedException();
        }
    }
}