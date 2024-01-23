namespace BMI
{
    public class BmiCalculator
    {
        public static double GetBmi(double weight, double height) => weight / (height * height);
        public static string EvaluateWeightStatus(double Bmi)
        {
            if (Bmi < 18.25)
            {
                return "You are underweight";
            }
            if (Bmi < 25)
            {
                return "You are perfect in weight & shape";
            }
            if (Bmi < 18.25)
            {
                return "You are overweight";
            }
            return "Out of context";
        }
    }
}
