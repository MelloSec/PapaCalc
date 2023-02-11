using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PapaCalc
{
    public class CalculatorStarter
    {
        public static void StartCalculator()
        {
            Process.Start("calc.exe");
        }
    }
}
