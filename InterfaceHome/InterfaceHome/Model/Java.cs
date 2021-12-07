using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHome.Model
{
    class Java : IDuration, IFee
    {
        public void Duration()
        {
            Console.WriteLine("The course is 3 months");
        }

        public void MonthlyPayment()
        {
            Console.WriteLine("The price is 100 manat"); ;
        }
    }
}
