using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    class Hævekort : Card
    {
        Random random = new Random();
        public string prefix = "2400";

        public Hævekort (string name) : base ( name)
        {

        }

        public override string GetCardNumber()
        {
            string cardNum = this.prefix + CreateCardNum();
            return cardNum;

        }

        public override string GetExpirationDate(int amuondtOfYears)
        {

            string date = "XX / XX - XXXX";
            return date;

        }

        public override string GetAccountNumber()
        {
            string accoundNum = this.prefix + CreateAccoundNum();
            return accoundNum;
        }

        private string CreateAccoundNum()
        {
            return base.RandomNumsSeleter(10);
        }

        private string CreateCardNum()
        {
           return base.RandomNumsSeleter(12);
           
        }

    }
}
