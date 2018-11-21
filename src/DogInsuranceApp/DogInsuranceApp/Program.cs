using DogInsuranceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInsuranceApp
{
    class DogInsuranceCalculator
    {
        static void Main(string[] args)
        {

            // Dog's current actual age
            const int DOG_AGE = 6;


            int currentAge = 0;
            int ageOfDeath = 0;
            int percentCovered = 0;
            int deductible = 0;
            int majorClaims = 0;


            Console.WriteLine("Welcome to the Dog Insurance Calculator");


            // Validates the age input
            while ((currentAge = GetCurrentAge()) < DOG_AGE)
            {
                Console.WriteLine("--- Dog can't be younger than " + DOG_AGE.ToString() + " years. Try again --- \n");
            }


            // Validates the age of death input
            while ((ageOfDeath = GetAgeOfDeath()) < currentAge)
            {
                Console.WriteLine("--- Dog can't have died before " + currentAge.ToString() + " years old. Try again --- \n");
            }


            // Validates the percent covered input
            // THIS SEEMS LIKE THE WRONG WAY TO DO THIS
            do
            {
                percentCovered = GetPercentCovered();
                if (IsValidPercent(percentCovered) == false)
                {
                    Console.WriteLine("--- The only choices are 60, 70, and 80 percent. Try again --- \n");
                }
            }
            while (IsValidPercent(percentCovered) == false);



            // Validates the deductible input
            // THIS SEEMS LIKE THE WRONG WAY TO DO THIS
            do
            {
                deductible = GetDeductible();
                if (IsValidDeductible(deductible) == false)
                {
                    Console.WriteLine("--- The only choices are 250, 500, and 750 USD. Try again --- \n");
                }
            }
            while (IsValidDeductible(deductible) == false);



            // Validates the illness/injury input
            // still need to validate for only int as well
            while ((majorClaims = GetMajorClaims()) < 0)
            {
                Console.WriteLine("--- Dog can't have negative injuries. Try again --- \n");
            }


            var policyData = InsuranceValue.GetInsuranceValue(currentAge, ageOfDeath, percentCovered, deductible, majorClaims);
            Console.WriteLine(policyData.BasicInfo());

        }







        static int GetCurrentAge()
        {
            Console.WriteLine("Current age of Dog? eg: 6");
            var x = IntInput();
            return x;
        }



        static int GetAgeOfDeath()
        {
            Console.WriteLine("Estimated age of death? eg: 15");
            var x = IntInput();
            return x;
        }

        static int GetPercentCovered()
        {
            Console.WriteLine("Percent of Insurance Coverage? Choices: 60, 70, 80");
            var x = IntInput();
            return x;
        }

        static int GetDeductible()
        {
            Console.WriteLine("Yearly deductible in USD? Choices: 250, 500, 750");
            var x = IntInput();
            return x;
        }

        static int GetMajorClaims()
        {
            Console.WriteLine("How many major injuries/illnesses throughout lifetime? (avg $4000 each + max deductible) eg: 3");
            var x = IntInput();
            return x;
        }






        // The basic input method
        static int IntInput()
        {
            var temp = Console.ReadLine();
            Int32.TryParse(temp, out int x);
            return x;
        }



        static bool IsValidPercent(int percent)
        {
            switch (percent)
            {
                case 60:
                    return true;
                case 70:
                    return true;
                case 80:
                    return true;
                default:
                    return false;
            }
        }


        static bool IsValidDeductible(int deductible)
        {
            switch (deductible)
            {
                case 250:
                    return true;
                case 500:
                    return true;
                case 750:
                    return true;
                default:
                    return false;
            }
        }


    }

}
