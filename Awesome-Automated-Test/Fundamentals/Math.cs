using System.Collections.Generic;

namespace Awesome_Automated_Test.Fundamentals
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            if (a < b)
                return b;
            return a;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}