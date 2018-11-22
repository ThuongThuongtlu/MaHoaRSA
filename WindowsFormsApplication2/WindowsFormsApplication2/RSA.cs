using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

struct KhoaCongKhai
{
    public BigInteger n;
    public BigInteger e;
}
struct KhoaBiMat
{
    public BigInteger n;
    public BigInteger d;
}

namespace WindowsFormsApplication2
{
    class RSA
    {
        public BigInteger MaHoaRSA(BigInteger P,KhoaCongKhai x)
        {
            BigInteger C;
            C = pow(P, x.e, x.n);
            return C;
        }
        public BigInteger GiaiMaRSA(BigInteger C, KhoaBiMat y)
        {
            BigInteger P;
            P = pow(C, y.d, y.n);
            return P;
        }
        public BigInteger pow(BigInteger a, BigInteger d, BigInteger n)
        {
            BigInteger result = 1;
            a = a % n;
            while (d > 0)
            {
                if ((d & 1) == 1) result = result * a % n;
                d >>= 1;
                a = a * a % n;
            }
            return result;
        }
    }
}
