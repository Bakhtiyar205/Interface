using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHome
{
    interface IFee
    {
        void MonthlyPayment();

        void YearlyPayment() 
        {
            Console.WriteLine( "There is 30% discount for yearly payment" );
        }
    }
}
