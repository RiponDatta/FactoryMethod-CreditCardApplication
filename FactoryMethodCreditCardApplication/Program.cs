using System;
using FactoryMethodCreditCardApplication.Factory;

namespace FactoryMethodCreditCardApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ICardFactory factory = null;
            string cardType = "MoneyBack";

            switch (cardType)
            {
                case "MoneyBack":
                    factory = new MoneyBackFactory(12000, 0);
                    break;
                case "RewardBack":
                    factory =new RewardBackFactory(8000, 100);
                    break;
                default:
                    break;
            }

            var creditCard = factory.GetCreditCard();
            Console.WriteLine(
                $"Card details: \nCard Type: {creditCard.CardType}\nCredit Limit: {creditCard.CardLimit}\nAnnual Fee: {creditCard.AnnualFee}");
        }
    }
}
