using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.CalculatorCore
{
    public interface ICalculator
    {
        float evaluate(string mathExpresion);
    }
}
