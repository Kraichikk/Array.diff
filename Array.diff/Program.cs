using System;
using System.Collections.Generic;
using System.Linq;

namespace SolutionArray.diff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 2, 3 };
            int[] value = { 2 };
            int[] result = ArrayDiff(array, value);

            foreach (var a in result)
            {
                Console.WriteLine(a);
            }
        }


        //mySolution
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var list = new List<int>(a);
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        list.RemoveAt(i - count);
                        count++;
                    }
                }
            }
            int[] array = new int[list.Count];
            array = list.ToArray();
            return array;
        }
        //more clever solution
        public static int[] ArrayDiff2(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
