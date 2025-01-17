﻿namespace IteratorPattern
{
    /// <summary>
    /// 迭代器模式
    /// </summary>
    static class Program
    {
        private static void Main()
        {
            var breakfast = new BreakfastMenu();
            var dinner = new DinnerMenu();
            var waiter = new Client(breakfast, dinner);
            waiter.PrintMenu();
        }
    }
}
