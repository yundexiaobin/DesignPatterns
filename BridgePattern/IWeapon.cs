namespace BridgePattern
{
    /// <summary>
    /// 抽象层
    /// </summary>
    public interface IWeapon
    {
        void Wield();
        void Swing();
        void Unwield();
        IEnchantment GetEnchantment();
    }
}