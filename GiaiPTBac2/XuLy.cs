using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTBac2
{
    public class XuLy
    {
        public string GiaiPT(ref double a, ref double b, ref double c)
        {
            string kq = "";
            if (a == 0)
            {
                kq = "Day khong phai pt bac 2!";
            }
            else
            {
                double dt = b * b - 4 * a * c;
                if (dt < 0)
                {
                    kq = "Pt vo nghiem!";
                }
                else if (dt == 0)
                {
                    double x = -b / (2 * a);
                    kq = "Phuong trinh co nghiem kep= " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(dt)) / (2 * a);
                    kq = "(x1,x2)= " +Math.Round( x1,2) + "," + Math.Round(x2,2);
                }
            }
            return kq;
        }
    }
}
