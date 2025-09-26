using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BMIHelper
    {
        public static double CalculateBMI(double heightCm, double weightKg)
        {
            if (heightCm <= 0 || weightKg <= 0) return 0;

            double heightM = heightCm / 100.0;
            double bmi = weightKg / (heightM * heightM);
            return Math.Round(bmi, 2);
        }
    }
}
