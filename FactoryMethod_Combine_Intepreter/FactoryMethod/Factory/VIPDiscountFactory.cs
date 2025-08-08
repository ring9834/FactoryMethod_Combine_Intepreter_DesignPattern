using FactoryMethod_Combine_Intepreter.FactoryMethod.Products;
using FactoryMethod_Combine_Intepreter.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Factory
{
    public class VIPDiscountFactory : DiscountFactory
    {
        public override IDiscountCalculator CreateDiscountCalculator()
        {
            return new VIPDiscountCalculator();
        }

        public override IDiscountRule CreateDiscountRule()
        {
            return new AndRule(new VIPRule(), new TotalSpentRule(1000m));
        }
    }
}
