namespace ExHeranca.Entities
{
    class LegalPerson : Person
    {
        public int NumEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numEmployees) : base(name, annualIncome)
        {
            NumEmployees = numEmployees;
        }

        public override double CalcTaxes()
        {
            double taxes;

            if (NumEmployees <= 10)
            {
                taxes = AnnualIncome * 0.16;    
            }
            else
            {
                taxes = AnnualIncome * 0.14;
            }

            return taxes;
        }
    }
}
