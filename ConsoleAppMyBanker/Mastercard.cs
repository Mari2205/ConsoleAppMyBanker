using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    class Mastercard : Card
    {
        public string prefix;

        Random random = new Random();
        public Mastercard(string name) : base(name)
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

        private string CreateAccoundNum()
        {
            return base.RandomNumsSeleter(12);
        }

        private string CreateCardNum()
        {
            return base.RandomNumsSeleter(14);

        }

        private string GetPrefix()
        {
            switch (random.Next(1, 10))
            {
                case 1:
                    prefix = "51";
                    break;
                case 2:
                    prefix = "52";
                    break;
                case 3:
                    prefix = "53";
                    break;
                case 4:
                    prefix = "54";
                    break;
                case 5:
                    prefix = "55";
                    break;
                default:
                    break;

            }
            return prefix;
        }
    }

}

