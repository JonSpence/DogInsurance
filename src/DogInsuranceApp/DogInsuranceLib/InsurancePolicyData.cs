using System;
using System.Collections.Generic;
using System.Text;

namespace DogInsuranceLib
{
    /// <summary>
    /// Information about a possible insurance policy
    /// </summary>
    public class InsurancePolicyData
    {
        public int yearsInsured { get; set; }
        public float yearlyPremium { get; set; }
        public float premiumIncrease { get; set; }
        public float totalPaid { get; set; }
        public float withoutInsurance { get; set; }

        /// <summary>
        /// Output the final amount
        /// </summary>
        /// <returns></returns>
        public string BasicInfo()
        {
            return "Total paid over " + yearsInsured + " years (including yearly premium increases): $" + totalPaid.ToString("0.00") + "\nWithout insurance, you would have paid: $" + withoutInsurance.ToString("0.00");
        }
    }
}
