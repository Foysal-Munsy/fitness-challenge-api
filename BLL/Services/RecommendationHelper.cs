using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RecommendationHelper
    {
        public static string GetRecommendation(double bmi)
        {
            if (bmi < 18.5)
                return "You are underweight. Eat more nutritious food and do strength training.";
            else if (bmi < 24.9)
                return "You are healthy. Maintain your routine and balanced diet.";
            else if (bmi < 29.9)
                return "You are overweight. Consider more physical activity and a lighter diet.";
            else
                return "You are obese. It's recommended to consult a doctor for a personalized plan.";
        }
    }

}
