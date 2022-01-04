using System;

namespace ProxyPattern
{
    /// <summary>
    /// 代理模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("testImage.jpg");

            //image will be loaded from disk
            image.display();
            Console.WriteLine("");

            //image will not be loaded from disk
            image.display();
        }
    }
}
