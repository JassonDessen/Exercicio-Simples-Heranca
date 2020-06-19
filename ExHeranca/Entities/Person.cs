namespace ExHeranca.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalcTaxes();

        public override string ToString()
        {
            return $"{Name} - {string.Format("{0:c2}", CalcTaxes())}";
        }
    }
}
