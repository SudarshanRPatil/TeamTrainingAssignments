using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderLine apple = new OrderLine(quantity: 1, unitPrice: 20m, discount: 0.0f);

            Console.WriteLine("Original Apple Price :{0}", apple.Total);

            OrderLine discountedRate = apple.WithDiscount(.5f);
            OrderLine unitPriceRate = apple.WithUnitPrice(30m);
            OrderLine quantityRate = apple.WithQuantity(2);

            Console.WriteLine("Discounted Apple Price :{0}", discountedRate.Total);
            Console.WriteLine("UnitPriceRate Apple Price :{0}", unitPriceRate.Total);
            Console.WriteLine("QuantityRate Apple Price :{0}", quantityRate.Total);

            Console.ReadKey();
        }
    }
}
