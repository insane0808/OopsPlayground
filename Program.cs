using System.Net;

using System;

namespace OopsPlayGround
{      
    //static property does not require instance , they belong to a class than a instance

    class Program
    {
        public static void Main()
        {   
            //destructor example 
            PaymentProcess  paymentProcess = new PaymentProcess(32.2,"ACH");
            Console.WriteLine(paymentProcess.GetPaymentAmount());
            Console.WriteLine(paymentProcess.GetPaymentInstruments());

            //inheritance example
            UnsecuredLoanApplication personalLoan = new UnsecuredLoanApplication();
            personalLoan.ApplicantName = "Satyam";
            personalLoan.LoanAmount = 400203.3;
            personalLoan.ApplicantSalary = 40000;
            personalLoan.LoanStatus();


            //Encapsulation
            CreditCard creditcard = new CreditCard();
            creditcard.SetDetails("123456789876","12/31","344");
            creditcard.GetDetails();
            creditcard.CardType = "Visa";


        }        
    }

}