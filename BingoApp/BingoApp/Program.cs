using System;
using System.Collections.Generic;

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
                    if (n == 0) // nollasarakkeen eli ensimmäisen = B-sarakkeen käsittely
                    {
                        //luodaan apulista mahdollisten tuplanumeroiden tarkistamista varten
                        var apulista = new List<int>();
                        // laskuri-muuttuja laskee, että saamme 5 numeroa
                        int laskuri = 0;
                        // arvotaan numeroita niin kauan kunnes saadaan yksilölliset arvot
                        bool onkoJo = true;

                            while (onkoJo == true)
                            {
                                // arvotaan numerot, sarake kerrallaan (p = rivi, n = sarake)
                                int numero = ArvoNumero(1, 15);

                                // etsitään onko juuri arvottu numero jo listalla
                                bool tulos = apulista.Exists(x => x == numero);
                                Console.WriteLine(tulos);
                                if (tulos == false)
                                {
                                    if (laskuri < 5)
                                    {
                                        //lisätään arvottu numero apulistalle, jotta sitä ei laiteta kupongille uudelleen
                                        apulista.Add(numero);

                                        foreach (int c in apulista)
                                        {
                                            Console.WriteLine(c);
                                        }

                                        laskuri = laskuri + 1;
                                    }
                                    else
                                    {
                                        onkoJo = false;
                                    }
                                }
                                else
                                {
                                    continue;
                                }


                            }


                        for (int p = 0; p < 5; p++)
                        {
                            // kun 5 numeroa arvottu, lisätään ne bingolapulle

                            Console.WriteLine(apulista[p]);
                            bingolappu[p, n] = apulista[p];

                            
                        }
                        

                    }
                    if (n == 1)
                    {
                        for (int p = 0; p < 5; p++) 
                        {
                            // arvotaan numerot sarake kerrallaan (p = rivi, n = sarake)
                            bingolappu[p, n] = ArvoNumero(16, 30);
                        }
                    }
                    if (n == 2)
                    {
                        for (int p = 0; p < 5; p++) 
                        {
                            // arvotaan numerot sarake kerrallaan (p = rivi, n = sarake)
                            bingolappu[p, n] = ArvoNumero(31, 45);
                        }
                    }
                    if (n == 3)
                    {
                        for (int p = 0; p < 5; p++) 
                        {
                            // arvotaan numerot sarake kerrallaan (p = rivi, n = sarake)
                            bingolappu[p, n] = ArvoNumero(46, 60);
                        }
                    }
                    if (n == 4)
                    {
                        for (int p = 0; p < 5; p++) 
                        {
                            // arvotaan numerot sarake kerrallaan (p = rivi, n = sarake)
                            bingolappu[p, n] = ArvoNumero(61, 75);
                        }
                    }

                }


                Console.WriteLine("B I N G O");
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

            Console.WriteLine("Aloitetaan Bingo!");


            Console.ReadLine();
        }

        /* Aliohjelma kupongin numeroiden arvontaan, 75 numeron bingo
           B = 1-15
           I = 16-30
           N = 31-45
           G = 46-60
           O = 61-75
        */
        private static int ArvoNumero(int min, int max)
        {
            var Random = new Random();
            int JokuNumero = Random.Next(min, max);
            return JokuNumero;
        }
        
    }
}
