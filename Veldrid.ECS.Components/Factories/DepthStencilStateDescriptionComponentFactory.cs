namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class DepthStencilStateDescriptionComponentFactory : IDepthStencilStateDescriptionComponentFactory
    {
        public DepthStencilStateDescriptionComponentFactory()
        {
        }

        public DepthStencilStateDescriptionComponent Create()
        {
            DepthStencilStateDescriptionComponent component = default;

            try
            {
                component = new DepthStencilStateDescriptionComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}