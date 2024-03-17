using Lab01.SalaryApp;

do
{
        Console.Clear();
        Console.Write("Gross Salary: $");
        decimal grossSalary = Convert.ToDecimal(Console.ReadLine());

        var salarySlip  = SalaryCalculator.ProcessSalarySlip(grossSalary);

        Console.WriteLine($"Gross Salary: {salarySlip.GrossSalary.ToString("C")}");
        Console.WriteLine($"Federal Tax (2%): {salarySlip.FederalTax.ToString("C")}");
        Console.WriteLine($"Social Security (7%): {salarySlip.SocialSecurity.ToString("C")}");
        Console.WriteLine($"health Insurance (Flat): {salarySlip.HealthInsurance.ToString("C")}");
        Console.WriteLine($"Total Deductions: {salarySlip.TotalDeductions.ToString("C")}");
        System.Console.WriteLine("--------------"); 
        Console.WriteLine($"Net Salary: {salarySlip.NetSalary.ToString("C")}");
        Console.ReadKey();
}while(true);