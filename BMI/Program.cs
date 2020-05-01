using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BMI
{
    class Program
    {
        //  Declare and initialize height constants
        const int MINHEIGHT = 12;           //  Minimum height allowed
        const int MAXHEIGHT = 96;           //  Maximum height allowed
        const int DEFHEIGHT = 72;           //  Default height value

        //  Declare and initialize weight constants
        const int MINWEIGHT = 1;            //  Minimum weight allowed
        const int MAXWEIGHT = 777;          //  Maximum weight allowed
        const int DEFWEIGHT = 175;          //  Default weight value

        //  Declare and initialize BMI constants
        const double MINOPT = 18.5;         //  Minimum optimal weight amt
        const double MINOV  = 30.0;         //  Minimum overweight amt

        static void Main(string[] args)
        {
            //  Declare and initialize constants
            int height          = 0;    //  Person's height
            int weight          = 0;    //  Person's weight
            double bmi          = 0.0;  //  Person's BMI
            string bmiStatus    = "";   //  underweight, overweight, etc.

            while (1 == 1)
            {   //  Begin while (1 == 1)
                height = inputHeight();
                weight = inputWeight();
                bmi = calculateBMI(height, weight);
                bmiStatus = calculateBMIStatus(bmi);
                displayAll(height, weight, bmi, bmiStatus);
            }   //  End   while (1 == 1)
        }

        static int inputHeight()
        {
            int h = 0;              //  Inputted height

            Write("\nPlease enter height (12 - 96): ");
            h = Convert.ToInt32(ReadLine());

            if ((h < MINHEIGHT) || (h > MAXHEIGHT))
            {
                WriteLine("\nOut-Of-Range Input!");
                WriteLine("Resetting height to 72\n");
                h = DEFHEIGHT;
            }

            return h;
        }

        static int inputWeight()
        {
            int w = 0;

            Write("Please enter weight (1 - 777): ");
            w = Convert.ToInt32(ReadLine());

            if ((w < MINWEIGHT) || (w > MAXWEIGHT))
            {
                WriteLine("\nOut-Of-Range Input!");
                WriteLine("Resetting weight to 175\n");
                w = DEFWEIGHT;
            }

            return w;
        }

        static double calculateBMI(int height, 
                                   int weight)
        {
            return ((weight / (Math.Pow(height, 2))) * 703.0);
        }

        static string calculateBMIStatus(double bmi)
        {
            string weightStr = "";

            if ((bmi >= 0) && (bmi < MINOPT))
            {
                weightStr = "Underweight";
            }
            else if ((bmi >= MINOPT) && (bmi < MINOV))
            {
                weightStr = "Optimal weight";
            }
            else if (bmi >= MINOV)
            {
                weightStr = "Overweight";
            }
            else
            {
                weightStr = "Error Occurred!";
            }

            return weightStr;
        }

        static void displayAll(int height, 
                               int weight, 
                               double bmi,
                               string bmiStatus)
        {
            WriteLine("\nHeight:  " + height.ToString());
            WriteLine("Weight:  "   + weight.ToString());
            WriteLine("BMI:  "      + bmi.ToString("n2"));
            WriteLine("BMI:  "      + bmiStatus);
        }
    }
}
