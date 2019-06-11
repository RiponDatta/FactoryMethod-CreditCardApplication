namespace FactoryMethodCreditCardApplication.CreditCard
{
    public interface ICreditCard
    {
        string CardType { get; }
        int CardLimit { get; set; }
        int AnnualFee { get; set; }
    }
}
