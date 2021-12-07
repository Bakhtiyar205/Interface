using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHome.Model
{
    class CSharp : IFee, IDuration
    {
        public void Duration()
        {
            Console.WriteLine("3 month");
        }

        public void MonthlyPayment()
        {
            Console.WriteLine("The price is in a month equal to 100 manat");
        }
    }
}
