namespace Cargo.src.interfaces
{
    internal interface IMenu
    {
        public Dictionary<string, Action> Choices { get; set; }
        public abstract void Render();
    }
}
