using System;
using System.Globalization;
using System.Linq;

namespace Session03Exersise01
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleMid = 0;
            double dblSum = 0;

            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool parsed;

                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);
                    parsed = true;
                }

                catch (Exception)
                {
                    numberArray[i] = 0;
                    parsed = false;
                }

                if (parsed == false)
                {
                    continue;
                }

                dblSum += numberArray[i].Value;
            }
            doubleMid = dblSum / numberArray.Length;


            Console.WriteLine($"Min value is: {numberArray.Min()} Maxvalue is: {numberArray.Max()} Total value is: {dblSum} Midvalue is: {doubleMid}");

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;
            //    bool parsed = double.TryParse(inputArray[i], out double parsedValue);

            //if (parsed == true)
            //{
            //    numberArray[i] = parsedValue;
            //}
            //else
            //{
            //    numberArray[i] = null;
            //}
        }   

        //static double GetDoubleValue(string input)
        //{
        //    try
        //    {
        //        //numberArray[i] = Convert.ToDouble(inputArray[i]);
        //        var result = int.Parse(input);
        //        return result;
        //    }
        //    catch (FormatException ex)
        //    {
        //        return double.MinValue;

        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //}
    }
}
