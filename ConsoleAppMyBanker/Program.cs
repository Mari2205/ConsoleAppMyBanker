using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();

            gui.GetTerminal();

            bool exit = false;



            while (!exit)
            {

                int userChooseCard = int.Parse(Console.ReadLine());

                switch (userChooseCard)
                {
                    case 1:
                        gui.CardChooseingSetUp();
                        string usrName = Console.ReadLine();
                        Console.Clear();
                        gui.GetDeteliesForHævekort();

                        Card hævekort = new Hævekort(usrName);
                        Console.Write(hævekort.ToString());
                        Console.WriteLine(hævekort.GetExpirationDate(0)); 
                        break;

                    case 2:
                        gui.CardChooseingSetUp();
                        usrName = Console.ReadLine();
                        Console.Clear();
                        gui.GetDeteliesForMaestro();

                        Card meastro = new Maestro(usrName);
                        Console.WriteLine(meastro.ToString());
                        Console.WriteLine(meastro.GetExpirationDate(5));

                        break;


                    case 3:
                        gui.CardChooseingSetUp();
                        usrName = Console.ReadLine();
                        Console.Clear();
                        gui.GetDeteliesForVISAEletron();

                        Card visaElectron = new VISAElectron(usrName);
                        Console.WriteLine(visaElectron.ToString());
                        Console.WriteLine(visaElectron.GetExpirationDate(5));
                        break;


                    case 4:
                        gui.CardChooseingSetUp();
                        usrName = Console.ReadLine();
                        Console.Clear();
                        gui.GetDeteliesForVISADankort();

                        Card visaDankort = new VISADankort(usrName);
                        Console.WriteLine(visaDankort.ToString());
                        Console.WriteLine(visaDankort.GetExpirationDate(5));
                        break;


                    case 5:
                        gui.CardChooseingSetUp();
                        usrName = Console.ReadLine();
                        Console.Clear();
                        gui.GetDeteliesForMastercard();

                        Card mastercard = new Mastercard(usrName);
                        Console.WriteLine(mastercard.ToString());
                        Console.WriteLine(mastercard.GetExpirationDate(5));
                        break;


                    case 6:
                        exit = true;
                        break;


                    default:
                        Console.WriteLine("Please enter a valid number ");
                        break;
                }
            }



            Console.ReadKey();
        }
    }
}
