/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Payment Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senior_Project
{
    public class Payment
    {
        //payment attributes
        string paymentType;
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        string cardType;
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        string cardNum;
        public string CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }
        double payAmount;
        public double PayAmount
        {
            get { return payAmount; }
            set { payAmount = value; }
        }
       
    }
}
