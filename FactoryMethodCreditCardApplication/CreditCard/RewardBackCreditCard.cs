namespace FactoryMethodCreditCardApplication.CreditCard
{
    public class RewardBackCreditCard : ICreditCard
    {
        public RewardBackCreditCard(int creditLimit, int annualFee)
        {
            CardType = "RewardBack";
            CardLimit = creditLimit;
            AnnualFee = annualFee;
        }

        public string CardType { get; }

        public int CardLimit { get; set; }

        public int AnnualFee { get; set; }
    }
}
