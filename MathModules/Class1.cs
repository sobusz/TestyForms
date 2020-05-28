using System;


namespace MathModules
{
    public class CalculatePithagoras{
        public double calcSideC(double sideA, double sideB)
        {
            double result = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);

            double finalResult = Math.Round(Math.Sqrt(result), 4);

            if (sideA < 0 )
                throw new ArithmeticException("Bok A nie może być ujemny");
            if (sideB < 0)
                throw new ArithmeticException("Bok B nie może być ujemny");
            if (sideA == 0)
                throw new ArithmeticException("Bok A nie może być równy zero");
            if (sideB == 0)
                throw new ArithmeticException("Bok B nie może być równy zero");

            return finalResult;
        }
        public double calcCirc(double sideA, double sideB)
        {
            double result = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);

            double finalResult = Math.Round(Math.Sqrt(result), 4);

            double circResult = sideA + sideB + finalResult;

            if (sideA < 0)
                throw new ArithmeticException("Bok A nie może być ujemny przy obwodzie");
            if (sideB < 0)
                throw new ArithmeticException("Bok B nie może być ujemny przy obwodzie");
            if (sideA == 0)
                throw new ArithmeticException("Bok A nie może być równy zero przy obwodzie");
            if (sideB == 0)
                throw new ArithmeticException("Bok B nie może być równy zero przy obwodzie");

            return circResult;
 
        }
        public double calcArea(double sideA, double sideB)
        {
            double areaResult = (sideA * sideB) / 2;

            if (sideA < 0)
                throw new ArithmeticException("Bok A nie może być ujemny przy polu");
            if (sideB < 0)
                throw new ArithmeticException("Bok B nie może być ujemny przy polu");
            if (sideA == 0)
                throw new ArithmeticException("Bok A nie może być równy zero przy polu");
            if (sideB == 0)
                throw new ArithmeticException("Bok B nie może być równy zero przy polu");

            return areaResult;
        }

    }
}