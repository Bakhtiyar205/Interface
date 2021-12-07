using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHome.Model
{
    class JavaScript : IFee, IDuration
    {
        public void Duration()
        {
            Console.WriteLine("2 months is a course");
        }

        public void MonthlyPayment()
        {
            Console.WriteLine("70 manat is in a month"); ;
        }
    }
}
