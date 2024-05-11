namespace Sparky;

public class Calculator
{

    private List<int> RangeNumbers = new List<int>();
    
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public double AddNumbers(double a, double b)
    {
        return a + b;
    }
    
    public bool IsOddNumber(int a)
    {
        return a % 2 != 0;
    }

    public List<int> GetOddRange(int min, int max)
    {
        RangeNumbers.Clear();
        for (int i = min; i <= max; i++)
        {
            if (i % 2 != 0)
            {
                RangeNumbers.Add(i);
            }
        }
        return RangeNumbers;
    }
}