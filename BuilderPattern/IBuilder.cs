namespace BuilderPattern
{
    /// <summary>
    /// 生成器
    /// </summary>
    public interface IBuilder
    {
        void AddIngredients();
        void AddShape();
        void AddSize();
        void Reset();
        Hamburger Build();
    }
}
