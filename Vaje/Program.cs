using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Vaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NALOGA 1

            int[] tabelaStevil = new int[] { 2, 4, 7, 9, 10, 11, 13, 14, 17, 19, 20, 21, 25, 35, 49 };

            // A) izpiši vsoto števil iz tabele tabelaStevil, ki pri deljenju s 4 dajo ostanek 0 ali 2. 
            // Poizvedbo zapiši v obliki METODE.
            var vsota1 = tabelaStevil.Where(stevilo => (stevilo % 4 == 0) || (stevilo % 4 == 2));




            // B) izpiši števila iz tabele tabelaStevil, ki pri deljuenju z številom 7 dajo ostanek 0, 3 ali 5.
            // Poizvedbo zapiši v obliki POIZVEDBE.

            var vsota = from stevilo in tabelaStevil
                        where stevilo % 7 == 0
                        || stevilo % 7 == 3
                        || stevilo % 7 == 5
                        select stevilo;


            // NALOGA 2

            string[] tabelaNizov = new string[] { "Ana", "Lea", "Pia", "Miha", "Polona", "Nina", "Aleksandra", "Matija", "Larisa", "Marinka", "Laura" };

            // A) Nize v tabeli tabelaNizov izpiši kot en skupen niz, ki ima elemente tabele ločene z znakom "-".
            // Poizvedbo zapiši v obliki METODE.

            string niz = tabelaNizov.Aggregate((prva, druga) => prva + "-" + druga);
            Console.WriteLine(niz);


            // B) Izpiši besede v tabeli tabelaNizov, ki vsebujejo natanko dva a-ja (ne razlikujemo med velikimi in malimi črkami)
            // Uredi jih po prvi črki besede in nato po dolžini od najdaljše do najkrajše.
            // Poizvedbo zapiši v obliki METODE.
            var dvaA = tabelaNizov.Where(beseda => beseda.ToLower().Count(znak => znak == 'a') == 2);
       } 
    }
}
