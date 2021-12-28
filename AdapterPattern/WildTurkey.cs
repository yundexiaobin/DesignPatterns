using System;

namespace AdapterPattern
{
    /// <summary>
    /// 另一个数据提供方
    /// </summary>
    class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flies 100 Metres");
        }
    }
}
