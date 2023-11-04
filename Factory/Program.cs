using System;

namespace Factory
{
    /// <summary>
    ///     Design Pattern -- Factory -- minimal demo
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryResolveLatestShippingStatus factoryResolveLatestShippingStatusForUps = new FactoryUps();
            FactoryResolveLatestShippingStatus factoryResolveLatestShippingStatusForFedEx = new FactoryFedEx();

            Console.WriteLine(factoryResolveLatestShippingStatusForUps.ResolveLatestShippingStatus("1Z....."));
            Console.WriteLine(factoryResolveLatestShippingStatusForFedEx.ResolveLatestShippingStatus("1111111"));

            Console.ReadKey();
        }
    }
}
