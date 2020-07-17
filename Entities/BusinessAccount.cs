namespace Herança.Entities
{
    class BusinessAccount : Account    // A BusinessAccount vai ter tudo o que a Account tiver(Herança)
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() // Construtor padrão, criar o objeto sem passar os dados
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) // Aproveitamos o construtor da classe Account
        {
            LoanLimit = loanLimit;
        }
    }
}
