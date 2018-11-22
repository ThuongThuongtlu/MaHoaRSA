using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace WindowsFormsApplication2
{
    class RabinMiBigIntegerer
    {
        KeyValuePair<BigInteger, BigInteger> factor(BigInteger n)
        {
            BigInteger s = 0;
            while ((n & 1) == 0)
            {
                s++;
                n >>= 1;
            }
            return new KeyValuePair<BigInteger, BigInteger>(s, n); 
        }
        BigInteger pow(BigInteger a, BigInteger d, BigInteger n)
        {
            BigInteger result = 1;
            a = a % n;
            while (d > 0)
            {
                if ((d & 1)==1) result = result * a % n;
                d >>= 1;
                a = a * a % n;
            }
            return result;
        }
        bool test_a(BigInteger s, BigInteger d, BigInteger n, BigInteger a)
        {
            if (n == a) return true;
            BigInteger p = pow(a, d, n);
            if (p == 1) return true;
            for (; s > 0; s--)
            {
                if (p == n - 1) return true;
                p = p * p % n;
            }
            return false;
        }
        public bool miller(BigInteger n)
        {
            if (n < 2) return false;
            if ((n & 1) == 0) return n == 2;
            BigInteger s, d;
            s = factor(n - 1).Key;
            d = factor(n - 1).Value;
            return test_a(s, d, n, 2) && test_a(s, d, n, 3);
        }
    }
}
