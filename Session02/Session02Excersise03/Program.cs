using System;
using System.Net.WebSockets;

namespace Session02Excersise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary operation
            var additionResult = 1 + 2;
            Console.WriteLine($"Addition result {additionResult}");

            var incrementResult = ++additionResult;
            Console.WriteLine($"Increment result {incrementResult}");

            var trueValue = true;

            var falseValue = false;

            // Bitwise operationer
            var andResult = 0b0010 & 0b0100;        //0b0110;
            var orResult = 0b0001 | 0b0001;         //0b0001;
            var xorResult = 0b0001 ^ 0b0001;        //0b0000;

            Console.WriteLine($"and result {andResult}");
            Console.WriteLine($"or result {orResult}");
            Console.WriteLine($"xor result {xorResult}");

            var modulResult = 3 % 2;
            Console.WriteLine($"modul result {modulResult}");

            var highInteger = 1000;
            var integerDivisionResult = highInteger / 3;
            var doubleDivissionResult = highInteger / 3.0;

            Console.WriteLine($"integer division result {integerDivisionResult}");
            Console.WriteLine($"double division result {doubleDivissionResult}");

            //implicit värdekonvertering till double
            var forcedIntDivisionResult = (int)(highInteger / 3.0);
            Console.WriteLine($"forced int division result {forcedIntDivisionResult}");

            var conversionResult = Convert.ToInt32(doubleDivissionResult);

            Console.WriteLine($"Conversion result {conversionResult}");

            var midpointDivisionResult = 10.0 / 3.0;

            Console.WriteLine($"Midpoint division result {midpointDivisionResult}");
            Console.WriteLine($"castToInt" + ((int)midpointDivisionResult).ToString());
            Console.WriteLine($"ceiling " +  Math.Ceiling(midpointDivisionResult));
            Console.WriteLine($"floor " + Math.Floor(midpointDivisionResult));
            Console.WriteLine($"ceiling " + Math.Round(midpointDivisionResult));

            //T
            additionResult += 2;    //Samma som (additionalResult = additionalResult + 2)
            additionResult -= 2;
            additionResult *= 2;
            additionResult /= 2;

            //Boelska jämförelseoperatorer
            var greaterThanResult = 5 > 3;
            var lessThanResult = 5 < 3;
            var greaterOrEqual = 5 >= 5;
            var lessOrEqual = 3 <= 5;

            Console.WriteLine($"greaterThanResult {greaterThanResult}");
            Console.WriteLine($"lessThanResult {lessThanResult}");
            Console.WriteLine($"greater or Equal {greaterOrEqual}");
            Console.WriteLine($"less or equal {lessOrEqual}");

            var andOperationsResult = true && false;
            var orOperationResult = false || true;

            Console.WriteLine($"And operations Result {andOperationsResult}");
            Console.WriteLine($"Or operations Result {orOperationResult}");
            Console.ReadKey(true);
        }
    }
}
