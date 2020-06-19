namespace ExHeranca.Entities
{
    class IndividualPerson : Person
    {
        public double MedicalExpenses { get; set; }

        public IndividualPerson(string name, double annualIncome, double medicalExpenses)
            : base(name, annualIncome)
        {
            MedicalExpenses = medicalExpenses;
        }

        public override double CalcTaxes()
        {
            double taxes = 0.0;

            if (AnnualIncome < 20000.00)
            {
                if (MedicalExpenses > 0)
                {
                    taxes = (AnnualIncome * 0.15) - (MedicalExpenses * 0.5);
                }
                else
                {
                    taxes = AnnualIncome * 0.15;
                }
            }
            else
            {
                if (MedicalExpenses > 0)
                {
                    taxes = (AnnualIncome * 0.25) - (MedicalExpenses * 0.5);
                }
                else
                {
                    taxes = AnnualIncome * 0.25;
                }
            }

            return taxes;
        }
    }
}
