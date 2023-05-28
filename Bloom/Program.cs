using BloomFilter;
using System;

namespace Bloom
{
    internal class Program
    {
        private static IBloomFilter bloomFilter = FilterBuilder.Build(10000000, 0.01);

        static void Main(string[] args)
        {
            // Add elements to the filter
            bloomFilter.Add("FMF");
            bloomFilter.Add("FGG");
            bloomFilter.Add("FE");
            bloomFilter.Add("FF");
            bloomFilter.Add("FKKT");
            bloomFilter.Add("FDV");
            bloomFilter.Add("NTF");
            bloomFilter.Add("FERI");
            bloomFilter.Add("FA");
            bloomFilter.Add("MF");

            // Test pozitivnih rezultatov
            bool isElement1Present = bloomFilter.Contains("FMF");
            bool isElement2Present = bloomFilter.Contains("FGG");
            bool isElement3Present = bloomFilter.Contains("FE");

            Console.WriteLine("Pozitivni:");
            Console.WriteLine("FMF:" + isElement1Present);
            Console.WriteLine("FGG:" + isElement2Present);
            Console.WriteLine("FE:" + isElement3Present);

            // Test negativnih rezultatov
            bool isElement11Present = bloomFilter.Contains("EF");

            Console.WriteLine("\nNegativne vrednosti:");
            Console.WriteLine("EF:" + isElement11Present);

            // Test lažno pozitivnih rezultatov
            bool isElement12Present = bloomFilter.Contains("FRI");

            Console.WriteLine("\nLažno pozitivni:");
            Console.WriteLine("FRI:" + isElement12Present);

            Console.ReadLine();
        }
    }
}
