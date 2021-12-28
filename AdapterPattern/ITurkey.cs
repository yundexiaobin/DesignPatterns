namespace AdapterPattern
{
    /// <summary>
    /// 与IDuck不兼容的接口
    /// </summary>
    public interface ITurkey
    {
        void Gobble();
        void Fly();
    }
}
