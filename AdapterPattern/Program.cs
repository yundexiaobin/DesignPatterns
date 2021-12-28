
namespace AdapterPattern
{
    /// <summary>
    /// 适配器模式
    /// </summary>
    internal static class Program
    {
        private static void Main()
        {
            var turkey = new WildTurkey();
            var adapter = new TurkeyAdapter(turkey);

            Tester(adapter);
        }

        /// <summary>
        /// 使用兼容接口调用对象
        /// </summary>
        /// <param name="duck"></param>
        private static void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
