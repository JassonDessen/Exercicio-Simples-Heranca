using ExHeranca.Entities;
using System;
using System.Globalization;

namespace ExHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people;

            Console.Write("Entre com a quantidade de pagadores: ");
            int n = int.Parse(Console.ReadLine());
            people = new Person[n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com os dados do {i + 1}º: ");
                Console.Write("Física ou Jurídica (f/j)? ");
                char d = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Renda anual: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (d == 'f')
                {
                    Console.Write("Despesas médicas: ");
                    double medicalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    people[i] = new IndividualPerson(name, annualIncome, medicalExpenses);
                }
                else if (d == 'j')
                {
                    Console.Write("Número de empregados: ");
                    int numEmployees = int.Parse(Console.ReadLine());

                    people[i] = new LegalPerson(name, annualIncome, numEmployees);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Imposto pago:");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
