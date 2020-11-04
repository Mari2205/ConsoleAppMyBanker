using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    class Maestro : Card
    {
        public string prefix;

        Random random = new Random();
        public Maestro(string name) : base (name)
        {

        }

        public override string GetCardNumber()
        {
            string cardNum = GetPrefix() + CreateCardNum();
            return cardNum;

        }

        public override string GetAccountNumber()
        {
            string accoundNum = GetPrefix() + CreateAccoundNum();
            return accoundNum;
        }

        public override string GetExpirationDate(int amuondtOfYears)
        {
            DateTime baseDate = DateTime.Today;

            DateTime date = baseDate.AddMonths(8);
            string eDate = "year(s) from now: " + date.AddYears(5);
            
            return eDate;
        }

        private string CreateAccoundNum()
        {
            return base.RandomNumsSeleter(10);
        }

        private string CreateCardNum()
        {
            return base.RandomNumsSeleter(15);

        }

        private string GetPrefix()
        {
            switch (random.Next(1,10))
            {
                case 1:
                    prefix = "5018";
                    break;
                case 2:
                    prefix = "6759";
                    break;
                case 3:
                    prefix = "5020";
                    break;
                case 4:
                    prefix = "6761";
                    break;
                case 5:
                    prefix = "5038";
                    break;
                case 6:
                    prefix = "6762";
                    break;
                case 7:
                    prefix = "5893";
                    break;
                case 8:
                    prefix = "6763";
                    break;
                case 9:
                    prefix = "6304";
                    break;
                default:
                    break;

            }
            return prefix;
        }
    }
}
