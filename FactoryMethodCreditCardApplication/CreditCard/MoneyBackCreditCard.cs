namespace FactoryMethodCreditCardApplication.CreditCard
{
    public class MoneyBackCreditCard : ICreditCard
    {
        public MoneyBackCreditCard(int creditLimit, int annualFee)
        {
            CardType = "MoneyBack";
            CardLimit = creditLimit;
            AnnualFee = annualFee;
        }

        public string CardType { get; }

        public int CardLimit { get; set; }

        public int AnnualFee { get; set; }
    }
}
