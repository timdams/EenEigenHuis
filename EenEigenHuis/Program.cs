using System;

namespace EenEigenHuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Huis mijnEigenHuis = new Huis();

            mijnEigenHuis.VoegKamerToe(new Badkamer());
            mijnEigenHuis.VoegKamerToe(new DeluxeSlaapkamer());
            mijnEigenHuis.VoegKamerToe(new Salon(true));
            mijnEigenHuis.VoegKamerToe(new SlaapKamer(60));
            Gang g = new Gang(4555);
  
            mijnEigenHuis.VoegKamerToe(g);
            Console.WriteLine(mijnEigenHuis);
            Console.WriteLine(mijnEigenHuis.BerekenPrijs());
        }
    }
}
