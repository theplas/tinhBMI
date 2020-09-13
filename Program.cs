using System;

namespace bai1
{
    class Program
  {
        public double tinh(double height, double weight)
        {
            double bmi;

            height = height / 100;
			bmi = weight / (height * height);
			Console . WriteLine ( "Your BMI is: {0} " , Math . Round ( bmi , 4 ));
			if (bmi < 18.5)
				Console.WriteLine("Underweight.");
			else if (bmi >= 18.5 && bmi < 25)
				Console.WriteLine("Normal");
			else if (bmi >= 25 && bmi < 30)
				Console.WriteLine("Overweight");
			else if (bmi >= 30)
				Console.WriteLine("Obese");
        
            return bmi;
        }
        static void Main(string[] args)
        {
          Console.OutputEncoding = System.Text.Encoding.UTF8;
			double height;
			double weight;
			double bmi;
			Console . WriteLine ( " Enter height: " );
			height = Convert.ToDouble(Console.ReadLine());
			Console . WriteLine ( " Enter weight: " );
			weight = Convert.ToDouble(Console.ReadLine());
			
            Program n = new Program();
            bmi =n.tinh(height,weight);

        }
    }
}