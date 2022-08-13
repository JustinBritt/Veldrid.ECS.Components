namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class ViewportComponentFactory : IViewportComponentFactory
    {
        public ViewportComponentFactory()
        {
        }

        public ViewportComponent Create()
        {
            ViewportComponent component = default;

            try
            {
                component = new ViewportComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}