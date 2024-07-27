using System.Globalization;

namespace NumberFormats
{
    public class Program
    {
        static void Main(string[] args)
        {
            double actualValue = 175007510.4;
            string format1 = String.Format("{0:##,####,####}", actualValue);
            Console.WriteLine(format1);
            var format2 = String.Format("{0:N}", actualValue); // 1,750,075,123,400,000.50
            Console.WriteLine(format2);

            // Gets a NumberFormatInfo associated with the en-US culture.
            //NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            NumberFormatInfo nfi = new CultureInfo("bn-BD", false).NumberFormat;
            // Displays a negative value with the default number of decimal digits (2).
            var test = actualValue.ToString("C", nfi);
            Console.WriteLine(test);

            // Displays the same value with four decimal digits.
            nfi.CurrencyDecimalDigits = 3;
            test = actualValue.ToString("C", nfi);
            Console.WriteLine(test);

            Console.ReadLine();
        }
    }
}
