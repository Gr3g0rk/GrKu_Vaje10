using System;
using System.Threading.Tasks;

namespace AsyncInAwait
{

    internal class Slanina { }
    internal class Kava { }
    internal class Jajce { }
    internal class Sok { }
    internal class Toast { }

    class Program
    {
        static async Task Main(string[] args)
        {
            var stoparca = new System.Diagnostics.Stopwatch();

            stoparca.Start();

            Kava cup = NatociKavo();
            Console.WriteLine("Kava je pripravljena");
            await Task.WhenAll(SpeciJajca(2), SpeciToast(2), SpeciSlanino(3));
            Console.WriteLine("Jajca so pečena");
            Console.WriteLine("Slanina je pečena");

            NamaziPuter();
            NamaziMarmelado();
            Console.WriteLine("Toast je narejen");

            Sok sok = NatociSok();
            Console.WriteLine("Sok je pripravljen");

            Console.WriteLine();
            Console.WriteLine("ZAJTRK JE GOTOV!");
            Console.WriteLine();

            stoparca.Stop();

            Console.WriteLine($"za pripravo zajtrka si porabil {stoparca.Elapsed.TotalSeconds} minut.");
        }

        private static Sok NatociSok()
        {
            Console.WriteLine("Točim sok");
            return new Sok();
        }

        private static void NamaziMarmelado()
        {
            Console.WriteLine("Dal sem marmelado na toast");
        }

        private static void NamaziPuter()
        {
            Console.WriteLine("Dal sem puter na toast");
        }

        private static async Task<Toast> SpeciToast(int koliko)
        {
            Console.WriteLine("Dal sem toast v toaster");
            Console.WriteLine("Pečenje...");
            await Task.Delay(3000);
            Console.WriteLine("Odstrani toast iz toasterja");

            return new Toast();
        }

        private static async Task<Slanina> SpeciSlanino(int koliko)
        {
            Console.WriteLine($"Dal sem {koliko} slanine v ponev");
            Console.WriteLine("Pečenje ene strani slanine...");
            await Task.Delay(3000);
            Console.WriteLine("Obrnem slanino");
            Console.WriteLine("Pečenje druge strani slanine...");
            await Task.Delay(3000);
            Console.WriteLine("Slanino damo na krožnik");

            return new Slanina();
        }

        private static async Task<Jajce> SpeciJajca(int koliko)
        {
            Console.WriteLine("Prižgem ogenj...");
            await Task.Delay(3000);
            Console.WriteLine($"Razbijem {koliko} jajci");
            Console.WriteLine("Pečem jajca ...");
            await Task.Delay(3000);
            Console.WriteLine("Dam jajca na krožnik");

            return new Jajce();
        }

        private static Kava NatociKavo()
        {
            Console.WriteLine("Natočim kavo");
            return new Kava();
        }
    }
}