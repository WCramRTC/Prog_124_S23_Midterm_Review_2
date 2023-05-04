using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_Midterm_Review_2
{
    public class MyMathInstance
    {
        double num1;
        double num2;

        public MyMathInstance(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Add()
        {
            return num1 + num2;
        }

    }
}
