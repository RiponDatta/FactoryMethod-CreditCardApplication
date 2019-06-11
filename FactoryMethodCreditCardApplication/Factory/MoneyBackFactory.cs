using FactoryMethodCreditCardApplication.CreditCard;

namespace FactoryMethodCreditCardApplication.Factory
{
    public class MoneyBackFactory : ICardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualFee;

        public MoneyBackFactory(int creditLimit, int annualFee)
        {
            _creditLimit = creditLimit;
            _annualFee = annualFee;
        }
        public ICreditCard GetCreditCard()
        {
            return  new MoneyBackCreditCard(_creditLimit, _annualFee);
        }
    }
}
