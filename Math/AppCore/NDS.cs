using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.AppCore
{
    
    public class NDS 
    {
        //Simplify Fraction
        //f[0] as numerator,f[1] as denominator
        public static int[] FracSimp(int[] f)
        {
            int k, i;
            if (f[0] < f[1]) k = f[1];
            else k = f[0];
            for (i = k; i > 0; i--)
            {
                if (f[0] % i == 0 && f[1] % i == 0)
                {
                    f[0] = f[0] / i;
                    f[1] = f[1] / i;
                }
            }
            return f;
        }
        public static int[] FracSimp(double m)
        {
            int k, i, c;
            int[] f=new int[2];
            string a = m.ToString();
            if (a.Contains("."))
            {
                a = a.Substring(a.IndexOf("."));
                c = a.Length;
                f[0] = Convert.ToInt32(m * System.Math.Pow(10, c));
                f[1] = Convert.ToInt32(System.Math.Pow(10, c));
            }
            else
            {
                f[0] = Convert.ToInt32(m);
                f[1] = 1;
            }
            if (f[0] < f[1]) k = f[1];
            else k = f[0];
            for (i = k; i > 0; i--)
            {
                if (f[0] % i == 0 && f[1] % i == 0)
                {
                    f[0] = f[0] / i;
                    f[1] = f[1] / i;
                }
            }
            return f;
        }

        //Simplify Surds
        //f[0] as coefficient,f[1] as denominator
        public static int[] SimpSurd(int a)
        {
            int i;
            int[] f = new int[2];
            for (i = 1; i < a; i++ )
            {
                if (a % (i * i) == 0)
                {
                    f[0] = i;
                    f[1] = a / (i * i);
                }
            }
            return f;
        }
        //Absolute value
        public static int Abs(int a)
        {
            if (a < 0) a = -a;
            return a;
        }
        //Determinant calculation
        public static int Det(int a1,int b1,int c1,int a2,int b2,int c2,int a3,int b3,int c3)
        {
            int a;
            a = a1 * b2 * c3 + a2 * b3 * c1 + a3 * b1 * c2 - a3 * b2 * c1 - a1 * b3 * c2 - a2 * b1 * c3;
            return a;
        }
        public static int Det(int a, int b, int c, int d)
        {
            int x;
            x = a * d - b * c;
            return x;
        }
        //Matrix Multipultification
        public static int[,] MatMul(int[,] a,int[,]b)
        {
            int i = a.GetUpperBound(0);
            int j = a.GetUpperBound(1);
            int k = b.GetUpperBound(1);
            int[,] output = new int[i, k];
            for(int con = 0; con == i; con++)
            {
                for(int con2 = 0; con2 == j; con2++)
                {
                    for(int con3=0;con3==k;con3++)
                    {
                        output[con, con3] = a[con, con2] * b[con2, con3];
                    }
                }
            }
            return output;
        }
    }
}
