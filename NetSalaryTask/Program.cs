using System;
using System.Collections.Generic;

class Slab
{
    public double MinSalary { get; set; }
    public double MaxSalary { get; set; }
    public double TaxRate { get; set; }

    public Slab(double minSalary, double maxSalary, double taxRate)
    {
        MinSalary = minSalary;
        MaxSalary = maxSalary;
        TaxRate = taxRate;
    }
}

class Program
{
    static List<Slab> slabs = new List<Slab>();

    static void Main(string[] args)
    {
        slabs.Add(new Slab(0, 150000, 0));
        slabs.Add(new Slab(150000, 300000, 0.1));
        slabs.Add(new Slab(300000, 400000, 0.3));
        slabs.Add(new Slab(400000, 500000, 0.3));

        Console.WriteLine("Enter gross salary:");
        double grossSalary = double.Parse(Console.ReadLine());

        double tax = CalculateTax(grossSalary);
        double netSalary = grossSalary - tax;

        Console.WriteLine("Net salary is: {0}", netSalary);
        Console.ReadLine();
    }

    static double CalculateTax(double salary)
    {
        double tax = 0;
        foreach (Slab slab in slabs)
        {
            if (salary > slab.MinSalary && salary <= slab.MaxSalary)
            {
                tax += (salary - slab.MinSalary) * slab.TaxRate;
                break;
            }
            else if (salary > slab.MaxSalary)
            {
                tax += (slab.MaxSalary - slab.MinSalary) * slab.TaxRate;
            }
        }
        return tax;
    }
}
