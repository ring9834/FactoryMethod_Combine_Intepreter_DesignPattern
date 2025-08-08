using FactoryMethod_Combine_Intepreter.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter
{
    // Usage example
    class Program
    {
        static void Main()
        {
            var processor = new DiscountProcessor();

            // Test case 1: VIP customer
            var vipContext = new CustomerContext(
                purchaseCount: 20,
                totalSpent: 1500m,
                lastPurchaseDate: DateTime.Now.AddDays(-10),
                isVIP: true
            );

            decimal originalPrice = 100m;
            decimal discountedPrice = processor.ApplyDiscount(vipContext, originalPrice);
            Console.WriteLine($"VIP Customer - Original: ${originalPrice}, Discounted: ${discountedPrice}");

            // Test case 2: Loyal customer
            var loyalContext = new CustomerContext(
                purchaseCount: 15,
                totalSpent: 800m,
                lastPurchaseDate: DateTime.Now.AddDays(-20),
                isVIP: false
            );

            discountedPrice = processor.ApplyDiscount(loyalContext, originalPrice);
            Console.WriteLine($"Loyal Customer - Original: ${originalPrice}, Discounted: ${discountedPrice}");

            // Test case 3: Regular customer
            var regularContext = new CustomerContext(
                purchaseCount: 5,
                totalSpent: 300m,
                lastPurchaseDate: DateTime.Now.AddDays(-40),
                isVIP: false
            );

            discountedPrice = processor.ApplyDiscount(regularContext, originalPrice);
            Console.WriteLine($"Regular Customer - Original: ${originalPrice}, Discounted: ${discountedPrice}");
        }
    }
}
