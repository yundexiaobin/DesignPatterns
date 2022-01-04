namespace FlyweightPattern
{
    /// <summary>
    /// 享元模式
    /// </summary>
    static class Program
    {
        private static void Main()
        {
            var teaShop = new BubbleTeaShop();
            teaShop.Enumerate();
        }
    }
}