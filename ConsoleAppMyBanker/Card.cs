using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyBanker
{
    abstract class Card : IAccount
    {
        Random random = new Random();
        string name { get; set; }

        public Card(string name) 
        {
            this.name = name;

        }

        public virtual string GetCardNumber()
        {
            string cNum = "XXXX XXXX XXXX XXXX";
            return cNum;
        }

        public virtual string GetExpirationDate(int amuondtOfYears)
        {
            DateTime baseDate = DateTime.Today;

               string eDate = "year(s) from now: " + baseDate.AddYears(amuondtOfYears);
            return eDate;

        }

        public virtual string GetAccountNumber()
        {
            string aNum = "XXXXXXXXXXXXXX";
            return aNum;
        }



        public override string ToString()
        {
            string cardInfo = "Card holder is " + this.name + 
                "\nCard number is " + this.GetCardNumber() + 
                "\nAccount number is " + this.GetAccountNumber() + 
                "\nExpiration date is " /*+ this.GetExpirationDate()*/;

            return cardInfo;
        }

        public string RandomNumsSeleter(int maxNumber)
        {
            StringBuilder sBuilder = new StringBuilder();

            while (sBuilder.Length < maxNumber)
            {
                sBuilder.Append(random.Next(10).ToString());
            }

            return sBuilder.ToString();
        }
    }
}
