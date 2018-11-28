using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInsuranceLib
{
    public class InsuranceValue
    {
        #region Interface
        /// <summary>
        /// Prints out the insurance value of a proposed insurance policy
        /// </summary>
        /// <param name="currentAge">This is the current age of the pet being insured</param>
        /// <param name="ageOfDeath"></param>
        /// <param name="percentCovered"></param>
        /// <param name="deductible"></param>
        /// <param name="majorClaims"></param>
        public static InsurancePolicyData GetInsuranceValue(int currentAge, int ageOfDeath, int percentCovered, int deductible, int majorClaims)
        {
            var r = new InsurancePolicyData();

            r.yearsInsured = ageOfDeath - currentAge;
            var startingMonthlyPremium = (float)Math.Round(YearlyPremium(percentCovered, deductible), 2);

            //r.premiumIncrease = (float)Math.Round(PremiumIncrease(r.yearsInsured, r.startingMonthlyPremium), 2);

            // For each year we are insured, let's add up the premiums
            float premium = startingMonthlyPremium;
            r.monthlyPayments = new List<float>();
            for (int i = 0; i < r.yearsInsured; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    r.monthlyPayments.Add(premium);
                }
                premium = (float)Math.Round(premium * 1.17f, 2);
            }

            //r.totalPaid = r.premiumIncrease + (float)Math.Round(MajorClaims(majorClaims, percentCovered, deductible));
            r.totalPaid = (from p in r.monthlyPayments select p).Sum();
            r.withoutInsurance = majorClaims * 4000;

            return r;
        }
        #endregion

        #region Implementation
        private static float YearlyPremium(Int32 myPercent, Int32 myDeductible)
        {
            // This method calculates the yearly premium based on an array of sample values from healthypaws website

            // lowest premium for 6yo, 60pct, 750ded
            float basePremium = 32.74f;

            // create arrays for matching input amounts to array labels
            int[] percentLabels = new int[] { 60, 70, 80 };
            int[] deductibleLabels = new int[] { 250, 500, 750 };

            // create array with HealthyPaws insurance costs for 6yo small mixed breed
            float[,] arrayMultiplier = new float[3, 3] { { 1.34f, 1.5f, 1.66f }, { 1.11f, 1.24f, 1.36f }, { 1f, 1.11f, 1.23f } };

            // Calculate yearly premium
            int pct = Array.BinarySearch(percentLabels, myPercent);
            int ded = Array.BinarySearch(deductibleLabels, myDeductible);
            var myPremium = basePremium * arrayMultiplier[ded, pct];
            return myPremium;
        }



        private static float PremiumIncrease(Int32 myYearsInsured, float myYearlyPremium)
        {
            // This method calculates the premium increases over dog's lifetime

            // set the estimated yearly premium increase
            double rateOfIncrease = 1.17;
            double d1 = myYearsInsured;
            double d2 = myYearlyPremium;

            // raise the premium each year
            double d3 = Math.Pow(d2, rateOfIncrease);
            float myPremiumIncrease = Convert.ToSingle(d3) * (myYearsInsured * 12);

            // the total amount of premiums paid over dog's lifetime including yearly raises in premiums
            return myPremiumIncrease;
        }


        /// <summary>
        /// Calculates how much any major injuries/illnesses will save or cost
        /// </summary>
        /// <param name="majorClaims"></param>
        /// <param name="percentCovered"></param>
        /// <param name="deductible"></param>
        /// <returns></returns>
        private static float MajorClaims(int majorClaims, int percentCovered, int deductible)
        {
            // average cost of a major injury/illness
            var avgCost = 4000;
            float percentPaid = (100 - percentCovered) / 100f;

            // figure out how much the owner pays for each incident after paying the full deductible
            float total = ((((avgCost - deductible) * percentPaid) + deductible) * majorClaims);
            return total;
        }
        #endregion
    }
}
