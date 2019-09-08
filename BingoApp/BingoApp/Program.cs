using System;

namespace BingoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä montako kuponkia tehdään eli monta pelaajaa on
            Console.WriteLine("Monta kuponkia tehdään? ");
            int kuponkienLkm = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tulostetaan " + kuponkienLkm + " kuponkia.");

            for (int i = 0; i < kuponkienLkm; i++)
            {
                // Bingolapun luominen
                int[,] bingolappu;
                bingolappu = new int[5, 5];

                for (int n = 0; n < 5; n++)// rivien lukumäärä = 5
                {
                    for (int p = 0; p < 5; p++)//rivillä olevien sarakkeiden lukumäärä = 5
                    {
                        bingolappu[n, p] = ArvoNumero();
                    }
                }


                // Bingolapun tulostaminen taulukkoon
                for (int t = 0; t < 5 ; t++)// rivien lukumäärä = 5
                {
                    for (int j = 0; j < 5; j++)//rivillä olevien sarakkeiden lukumäärä = 5
                    {
                        Console.Write(bingolappu[t, j] + " "); //Tulostetaan taulukon solun arvot peräkkäin samalle riville + välilyönti
                    }
                    Console.WriteLine();//Rivien tulostuksen jälkeen tulostetaan rivinvaihto, jotta seuraava rivi tulostuisi seuraavalle riville

                }
                Console.WriteLine(); // rivinvaihto, jotta useammat laput eivät mene peräkkäin
            }



            Console.ReadLine();
        }

        // Aliohjelma kupongin numeroiden arvontaan
        private static int ArvoNumero()
        {
            var Random = new Random();
            int JokuNumero = Random.Next(0, 75);
            return JokuNumero;

        }
    }
}
