using System;

namespace FactoryPattern
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Yankees fan orders:");
            var yankees = new NyPizzaFactory();
            yankees.Order("Cheese");
            Console.WriteLine();
            Console.WriteLine("Cubs fan orders:");
            var cubs = new ChicagoPizzaFactory();
            cubs.Order("Clam");
        }
    }
}