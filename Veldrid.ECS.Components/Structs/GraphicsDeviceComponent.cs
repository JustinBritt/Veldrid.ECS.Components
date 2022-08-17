namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct GraphicsDeviceComponent
    {
        public GraphicsDeviceComponent(
            GraphicsDevice value)
        {
            this.Value = value;
        }

        public GraphicsDevice Value { get; set; }
    }
}