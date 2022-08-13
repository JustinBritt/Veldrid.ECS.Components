namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class GraphicsDeviceComponentFactory : IGraphicsDeviceComponentFactory
    {
        public GraphicsDeviceComponentFactory()
        {
        }

        public GraphicsDeviceComponent Create()
        {
            GraphicsDeviceComponent component = default;

            try
            {
                component = new GraphicsDeviceComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}