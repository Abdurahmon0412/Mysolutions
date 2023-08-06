namespace Practice19_2
{
    public class BankaAcount
    {

        public BankaAcount(string accountHolderName, string accountNumber) 
        {
            if (string.IsNullOrWhiteSpace(accountHolderName) || accountHolderName.Length < 3)
            {
                throw new ArgumentException("name id invalid");
            }
            else if (string.IsNullOrWhiteSpace(accountNumber) || accountNumber.Length < 16) 
            {
                throw new ArgumentException("name id invalid");
            }



            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.Balance = 0;
        }

        protected string accountHolderName;
        protected string accountNumber;
        protected double Balance;


        public virtual void Deposit()
        {

        }

        public virtual void Withdraw()
        {

        }
    }
}
