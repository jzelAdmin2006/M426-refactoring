using System;
using System.Linq;

namespace Refactoring {
    public static class Fibonacci {
        public static int Fib(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Fibonacci undefined for negative numbers");
            }
            return n == 0 || n == 1 ? 1 :
                Enumerable.Range(2, n - 1)
                .Aggregate((prev: 1, next: 1),
                    (fibN, _) => (fibN.next, fibN.prev + fibN.next))
                .next;
        }
    }
}
