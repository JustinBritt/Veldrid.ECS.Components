namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IGraphicsDeviceComponentFactory
    {
        GraphicsDeviceComponent Create(
            GraphicsDevice value);
    }
}