using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.AppCore
{
    public class linear
    {
        //Solve linear equation in two unknowns
        //r[0] is the numerator of x;r[1] is the donimonator of x;r[2] is the numerator of y;r[3] is the donimonator of y.
        public static int[] twounknown(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            int[] r=new int[4];
            r[0] = c1 * b2 - c2 * b1;
            r[1] = a1 * b2 - a2 * b1;
            r[2] = c1 * a2 - c2 * a1;
            r[3] = a2 * b1 - a1 * b2;
            return r;    
        }
        //Solve linear equation in three unknowns
        //r[0] is the value of x;r[1] is the value of y;r[2] is the value of z.
        public static double[] threeunknown(int a1,int b1,int c1,int d1,int a2,int b2,int c2,int d2,int a3,int b3,int c3,int d3)
        {
            double[] r = new double[3];
            r[0] = AppCore.NDS.Det(d1, b1, c1, d2, b2, c2, d3, b3, c3) / AppCore.NDS.Det(a1, b1, c1, a2, b2, c2, a3, b3, c3);
            r[1] = AppCore.NDS.Det(a1, d1, c1, a2, d2, c2, a3, d3, c3) / AppCore.NDS.Det(a1, b1, c1, a2, b2, c2, a3, b3, c3);
            r[2] = AppCore.NDS.Det(a1, b1, d1, a2, b2, d2, a3, b3, d3) / AppCore.NDS.Det(a1, b1, c1, a2, b2, c2, a3, b3, c3);
            return r;
        }
    }
}
