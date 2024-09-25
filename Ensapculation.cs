using System;

namespace OopsPlayGround
{
    // Encapsulation is a mechanisam of wrapping the data and code acting on the data in a single unit.
    // variables of a class will be hideen from other classes , and can be access through its propeties , it is also clalled as data hiding 
    

    // a fields of class can be made readonly and write onl , benefits of encapsulation
    // encapsulation helps us avoid corruption of data
    
    class CreditCard
    {
        private string CardNumber;
        
        private string ExpiryDate;
        private string CVV;

        private string _CardType;

        public void SetDetails(string cardNumber, string expiryDate , string cvv)
        {   //ccan have validation s per business requirements
            this.CardNumber = cardNumber;
            this.ExpiryDate = expiryDate;
            this.CVV = cvv;
        }

        public string CardType
        {
            set{
                //properties can also be set as private and public
                this._CardType= value;
            }
            get{
                return this._CardType;
            }
        }

        public void GetDetails()
        {
            Console.WriteLine(this.CardNumber);
            Console.WriteLine(this.ExpiryDate);
            Console.WriteLine(this.CVV);
            
        }
    }

}