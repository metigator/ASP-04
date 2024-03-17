namespace Lab01.SalaryApp
{
    public class SalaryCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="grossSalary">the gross salary</param>
        /// <returns></returns>
        public static SalarySlip ProcessSalarySlip(decimal grossSalary)
        {
            decimal federalTaxRate = 0.20m; // 20%
            decimal socialSecurityRate = 0.07m; // 7%
            decimal healthInsurance = 200m; // Flat rate

            decimal federalTax = grossSalary * federalTaxRate;
            decimal socialSecurity = grossSalary * socialSecurityRate;
            decimal totalDeductions = federalTax + socialSecurity + healthInsurance;

            decimal netSalary = grossSalary - totalDeductions;

            return new SalarySlip
            {
                GrossSalary = grossSalary,
                FederalTax = federalTax,
                SocialSecurity = socialSecurity,
                HealthInsurance = healthInsurance,
                NetSalary = netSalary
            };
        }
    }

    public class SalarySlip
    {
        public decimal GrossSalary {get; set;}
        public decimal FederalTax {get; set;}
        public decimal SocialSecurity {get; set;}
        public decimal HealthInsurance {get; set;}
        public decimal NetSalary {get; set;}

        public decimal TotalDeductions => FederalTax + SocialSecurity + HealthInsurance;
    }
}