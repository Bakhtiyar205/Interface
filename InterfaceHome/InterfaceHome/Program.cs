using InterfaceHome.Model;
using System;

namespace InterfaceHome
{
    class Program
    {
        static void Main(string[] args)
        {
            IFee cs = new CSharp();
            cs.YearlyPayment();

            Java jv = new Java();
            jv.MonthlyPayment();

            JavaScript jvs = new JavaScript();
            jvs.Duration();

            Console.ReadLine();
            
        }
    }
}
