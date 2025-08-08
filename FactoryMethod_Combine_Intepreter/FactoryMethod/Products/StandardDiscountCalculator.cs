using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Products
{
    // Concrete products for Factory Method
    public class StandardDiscountCalculator : IDiscountCalculator
    {
        public decimal CalculateDiscount(decimal originalPrice)
        {
            return originalPrice * 0.1m; // 10% discount
        }
    }
}
