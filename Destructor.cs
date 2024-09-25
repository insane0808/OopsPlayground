using System;

namespace OopsPlayGround
{   
    // destructors de-allocated the memory of the objects that are no longer required
    // destructors can not be overloaded and inherited
    // destructors can not be explicitly invoked 
    // destructors can not specify access modifiers  and can not take parameters.

    class PaymentProcess
    {
        public string PaymentInstruments;
        public double PaymentAmount;

        public PaymentProcess(double paymentAmount,string paymentInstruments)
        {
            this.PaymentInstruments= paymentInstruments;
            this.PaymentAmount = paymentAmount;
        }
        public double GetPaymentAmount()
        {
            return this.PaymentAmount;
        }

        public string GetPaymentInstruments()
        {
            return this.PaymentInstruments;
        }

        ~PaymentProcess()
        {
            Console.WriteLine("Destroying Object");
        }
    }
}