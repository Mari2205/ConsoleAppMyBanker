using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    class Gui
    {
        public void GetTerminal()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("                 Chose youre card            ");
            Console.WriteLine("=============================================");

            Console.WriteLine("Please choose which card you want to be made for you");

            Console.WriteLine("1. Hævekort ");
            Console.WriteLine("2. Maestro Card");
            Console.WriteLine("3. Visa Electronkort");
            Console.WriteLine("4. Visa dancard");
            Console.WriteLine("5. Mastercard");
            Console.WriteLine("6. Exit");
        }


        public void CardChooseingSetUp()
        {
            Console.Clear();
            Console.WriteLine("Write you´re full name: ");

        }

        public void GetDeteliesForHævekort()
        {
            Console.WriteLine("Dette kort tilbydes primært til kunder under 18 år \nhvilket betyder at pengene trækkes med det samme fra kontoen \nog der kan ikkelaves et overtræk.");
            Console.WriteLine("\n");
        }

        public void GetDeteliesForMaestro()
        {
            Console.WriteLine("dette kan bruges internationalt og på Nettet \nMan skal være 18 år");
            Console.WriteLine("\n");
        }
        public void GetDeteliesForVISAEletron()
        {
            Console.WriteLine("dette kan bruges internationalt og på Nettet \nkunden skal være over 15 år \nDer kan max. Bruges 10000 kr om måneden");
            Console.WriteLine("\n");
        }

        public void GetDeteliesForVISADankort()
        {
            Console.WriteLine("Dette er et delvist kreditkort med en grænse på 20.000 kr \nnMan skal være 18 år \nDette kort kan gå i overtræk og man kan hæve \nop til 25.000 kr.på dette kort om måneden ");
            Console.WriteLine("\n");
        }

        public void GetDeteliesForMastercard()
        {
            Console.WriteLine("kredit på op til 40.000 kr om måneden \nSaldoen opgøres en gang om måneden og kunden betaler sit udestående \nMan kan hæve op til 5000 kr. om dagen \ndette kort og op til 30.000 om måneden.");
            Console.WriteLine("\n");
        }




    }
}
