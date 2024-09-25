using System;

namespace OopsPlayGround{

    //inheritance allows you  to  create a class by deriving feature and attribute from parent class

    class LoanApplication
    {
        public string ApplicantName;
        public double LoanAmount;

        public void LoanStatus()
        {
            Console.WriteLine("Loan Application");
        }
    }
    
    class MortgageLoanApplication : LoanApplication
    {
        public required string AssetClass;

    }

    class HomeLoanApplication : MortgageLoanApplication
    {
        public required string PropertyArea;

    } 

    class UnsecuredLoanApplication : LoanApplication
    {
        public string PanCard;
        public double ApplicantSalary;
    }

}