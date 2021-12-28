namespace BridgePattern
{
    /// <summary>
    /// 抽象层
    /// </summary>
    public interface IEnchantment
    {
        void OnActivate();
        void Apply();
        void OnDeactivate();
    }
}