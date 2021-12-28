namespace BridgePattern
{
    /// <summary>
    /// 桥接模式，通过抽象层依赖，实现部分的不同组合来实现不同的形态
    /// </summary>
    internal static class Program
    {
        private static void Main()
        {
            //通过不同的组合，实现不同的IWeapon
            IWeapon sword = new Sword(new FlyingEnchantment());
            sword.Wield();
            sword.Swing();
            sword.Unwield();

            //通过不同的组合，实现不同的IWeapon
            IWeapon hammer = new Hammer(new SoulEatingEnchantment());
            hammer.Wield();
            hammer.Swing();
            hammer.Unwield();
        }
    }
}