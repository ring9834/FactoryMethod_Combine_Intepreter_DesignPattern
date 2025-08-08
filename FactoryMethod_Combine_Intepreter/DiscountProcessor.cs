using FactoryMethod_Combine_Intepreter.FactoryMethod.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter
{
    // Client code
    public class DiscountProcessor
    {
        private readonly List<DiscountFactory> _factories;

        public DiscountProcessor()
        {
            _factories = new List<DiscountFactory>
        {
            new VIPDiscountFactory(),
            new LoyalCustomerDiscountFactory(),
            new StandardDiscountFactory()
        };
        }

        public decimal ApplyDiscount(CustomerContext context, decimal originalPrice)
        {
            foreach (var factory in _factories)
            {
                var rule = factory.CreateDiscountRule();
                if (rule.Interpret(context))
                {
                    var calculator = factory.CreateDiscountCalculator();
                    return originalPrice - calculator.CalculateDiscount(originalPrice);
                }
            }
            return originalPrice; // No discount if no rules match
        }
    }
}
