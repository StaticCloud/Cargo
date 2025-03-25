namespace Cargo.src.interfaces
{
    internal interface IMenu
    {
        public Dictionary<string, Action> Choices { get; init; }
        public abstract void Render();
    }
}
