namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class RasterizerStateDescriptionComponentFactory : IRasterizerStateDescriptionComponentFactory
    {
        public RasterizerStateDescriptionComponentFactory()
        {
        }

        public RasterizerStateDescriptionComponent Create(
            RasterizerStateDescription value)
        {
            RasterizerStateDescriptionComponent component = default;

            try
            {
                component = new RasterizerStateDescriptionComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}