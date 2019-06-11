using FactoryMethodCreditCardApplication.CreditCard;

namespace FactoryMethodCreditCardApplication.Factory
{
    public interface ICardFactory
    {
        ICreditCard GetCreditCard();
    }
}
