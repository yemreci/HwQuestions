namespace Odev.Q3
{
    public class Recursive
    {
        public static int Recursion(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("Number can't be less than or equal to 0");
            }
            return num * Recursion(num - 1);
        }
    }
    
}
