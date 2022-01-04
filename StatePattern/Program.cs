﻿using System;

namespace StatePattern
{
    /// <summary>
    /// 状态模式
    /// </summary>
    static class Program
    {
        public static void Main()
        {
            LegacyTest();
            Console.WriteLine();
            var gumballmachine = new GumballMachine(5);
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
        }

        private static void LegacyTest()
        {
            var machine = new Legacy.GumballMachine(2);
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.InsertQuarter();
        }
    }
}
