using FactoryMethodCreditCardApplication.CreditCard;

namespace FactoryMethodCreditCardApplication.Factory
{
    public class RewardBackFactory : ICardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualFee;

        public RewardBackFactory(int creditLimit, int annualFee)
        {
            _creditLimit = creditLimit;
            _annualFee = annualFee;
        }
        public ICreditCard GetCreditCard()
        {
            return new RewardBackCreditCard(_creditLimit, _annualFee);
        }
    }
}
