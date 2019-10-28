using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GetPrime
{
   public class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var x = FindFourPrimes(1000);
            Console.WriteLine("prime 1: {0}", x[0]);
            Console.WriteLine("prime 2: {0}", x[1]);
            Console.WriteLine("prime 3: {0}", x[2]);
            Console.WriteLine("prime 4: {0}", x[3]);

            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            Console.ReadKey();
        }

        public static int[] FindFourPrimes(int N)
        {
            var lstPrimes = Primes(N);

            for (var a = 0; a < lstPrimes.Count(); a++)
            {
                for (var b = a + 1; b < lstPrimes.Count(); b++)
                {
                    for (var c = b + 1; c < lstPrimes.Count(); c++)
                    {
                        for (var d = c + 1; d < lstPrimes.Count(); d++)
                        {
                            if (IsSeqInt((long)lstPrimes[a] * lstPrimes[b] * lstPrimes[c] * lstPrimes[d]))
                            {
                                return new int[] { lstPrimes[a], lstPrimes[b], lstPrimes[c], lstPrimes[d] };
                            }
                        }
                    }
                }
            }

            return null;
        }

        public static bool IsSeqInt(long n)
        {
            var str = n.ToString();


            if (str.Length != 12) return false;

            var result = str.Select(s => int.Parse(s.ToString())).ToArray();
            var arr = result.OrderBy(x => x).ToArray();


            if (!arr.SequenceEqual(result))
            {
                return false;
            }

            var mx = result.Max();
            var mn = result.Min();

            for (int i = mn + 1; i < mx; i++)
            {
                bool inList = result.Contains(i);

                if (!inList)
                {
                    return false;
                }
            }

            Console.WriteLine("the product of primes is {0}", n.ToString());
            return true;
        }

        public static List<int> Primes(int N)
        {
            var lstPrimes = new List<int>();

            for (int num = 2; num <= N; num++)
            {
                int ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    lstPrimes.Add(num);
            }


            return lstPrimes;
        }
    }
}
