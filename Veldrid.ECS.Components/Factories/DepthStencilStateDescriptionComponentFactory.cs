namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class DepthStencilStateDescriptionComponentFactory : IDepthStencilStateDescriptionComponentFactory
    {
        public DepthStencilStateDescriptionComponentFactory()
        {
        }

        public DepthStencilStateDescriptionComponent Create(
            DepthStencilStateDescription value)
        {
            DepthStencilStateDescriptionComponent component = default;

            try
            {
                component = new DepthStencilStateDescriptionComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}