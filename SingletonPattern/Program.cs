using System;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式
    /// </summary>
    static class Program
    {
        static void Main()
        {
            try
            {
                var chocoEggs = ChocolateBoiler.GetInstance();
                chocoEggs.Fill();
                chocoEggs.Boil();
                chocoEggs.Drain();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}
