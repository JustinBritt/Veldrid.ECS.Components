namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct ViewportComponent
    {
        public ViewportComponent(
            Viewport value)
        {
            this.Value = value;
        }

        public Viewport Value { get; set; }
    }
}