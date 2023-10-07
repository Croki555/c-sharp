using System;

namespace Less19
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = {3,5,4,1,2};
            int[] num2 = new int[num.Length];
            int max = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        max = num[j];
                        num2[i] = max;
                    }
                }
            }

            foreach (var a in num2)
            {
                Console.WriteLine(a);
            }
        }
    }
}