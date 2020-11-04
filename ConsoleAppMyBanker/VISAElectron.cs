using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    class VISAElectron : Card
    {
        public string prefix;
        public int CifreFromPrefixAccount = 10;
        public int CifreFromPrefixCardNum = 12;

        Random random = new Random();
        public VISAElectron(string name) : base(name)
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
            return base.RandomNumsSeleter(CifreFromPrefixAccount);
        }

        private string CreateCardNum()
        {
            return base.RandomNumsSeleter(CifreFromPrefixCardNum);

        }

        private string GetPrefix()
        {
            switch (random.Next(1, 10))
            {
                case 1:
                    prefix = "4026";
                    break;
                case 2:
                    prefix = "417500";
                    CifreFromPrefixAccount = 8;
                    CifreFromPrefixCardNum = 10;
                    break;
                case 3:
                    prefix = "4508";
                    break;
                case 4:
                    prefix = "4844";
                    break;
                case 5:
                    prefix = "4913";
                    break;
                case 6:
                    prefix = "4917";
                    break;
                default:
                    break;

            }
            return prefix;
        }
    }
}
