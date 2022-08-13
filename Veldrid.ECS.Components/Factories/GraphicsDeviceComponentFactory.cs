namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class GraphicsDeviceComponentFactory : IGraphicsDeviceComponentFactory
    {
        public GraphicsDeviceComponentFactory()
        {
        }

        public GraphicsDeviceComponent Create(
            GraphicsDevice value)
        {
            GraphicsDeviceComponent component = default;

            try
            {
                component = new GraphicsDeviceComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}