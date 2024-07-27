using System.Globalization;

namespace NumberFormats
{
    public class Program
    {
        static void Main(string[] args)
        {
            double actualValue = 1750075123400.4;
            string format1 = String.Format("{0:##,####,####}", actualValue);
            Console.WriteLine(format1);
            var format2 = String.Format("{0:N}", actualValue); // 1,750,075,123,400,000.50
            Console.WriteLine(format2);

            Console.ReadLine();
        }
    }
}
