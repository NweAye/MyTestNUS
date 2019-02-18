using System;

namespace FirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //No.7
            //Console.Write("Distance Kilometer : ");
            //double km = double.Parse(Console.ReadLine());
            //double resultDouble = Math.Round((2.40 + km * 0.4),2);
            //int resultInt = (int)resultDouble;

            //double diff = resultDouble - resultInt;
            //int secondDecimal = (int)(diff * 100) % 10; 
            //int firstDecimal = (int)(diff * 10);
            //if (secondDecimal > 5 ) {
            //    firstDecimal++;
            //}
            //double final = resultInt + (firstDecimal / 10.0);
            //Console.Write($"Total Fare: {final : .00} ");

            //No.8
            //Console.Write("Distance Kilometer : ");
            //double km = double.Parse(Console.ReadLine());
            //double resultDouble = Math.Round((2.40 + km * 0.4), 2);
            //int resultInt = (int)resultDouble;

            //double diff = resultDouble - resultInt;
            //int secondDecimal = (int)(diff * 100) % 10;
            //int firstDecimal = (int)(diff * 10);
            //if (secondDecimal > 0 )
            //{
            //    firstDecimal++;
            //}
            //double final = resultInt + (firstDecimal / 10.0);
            //Console.Write($"Total Fare: {final: .0} ");

            // Other short way
            Console.Write("Distance Kilometer : ");
            double km = double.Parse(Console.ReadLine());
            double result = 2.40 + km * 0.4;
            Console.Write($"Total Fare: {Math.Ceiling(result * 10) / 10: .00} ");
        }
    }
}
