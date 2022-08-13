namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class ViewportComponentFactory : IViewportComponentFactory
    {
        public ViewportComponentFactory()
        {
        }

        public ViewportComponent Create(
            Viewport value)
        {
            ViewportComponent component = default;

            try
            {
                component = new ViewportComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}