using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class SayisalDegiskenler
    {
        static void Main(string[] args)
        {
            // Tam Sayılar
            // 1 2 3 4 5 6 7

            byte deger1 = 10;
            int deger2 = 100;

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            Console.WriteLine(byteMinValue);
            Console.WriteLine(byteMaxValue);

            Console.WriteLine(intMinValue);
            Console.WriteLine(intMaxValue);

            //-----------------------------------------------------------

            // Ondalıklı Sayılar

            // Double
            double doubleVal1 = 10.2;
            double doubleVal2 = 10;
            double doubleVal3 = 10.9d;

            double doubleMinVal = double.MinValue;
            double doubleMaxVal = double.MinValue;

            // Decimal
            decimal decimalVal1 = 10.2M;

            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MinValue;

            // Float
            float floatVal1 = 10.2F;

            float floatMinVal = float.MinValue;
            float floatMaxVal = float.MinValue;
        }
    }
}
