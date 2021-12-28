using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            //通过传入不同的生成器给主管类，可生成不同的产品
            var builder = new MyHamburgerBuilder();
            var cook = new Cook(builder);
            var myHamburger = cook.Build();

            cook.ChangeBuilder(new WifesHamburgerBuilder());
            var wifesHamburger = cook.Build();
            //两个是不同的产品
            Console.WriteLine($"My Hamburger: {myHamburger}");
            Console.WriteLine($"My Wife's Hamburger: {wifesHamburger}");
        }
    }
}
