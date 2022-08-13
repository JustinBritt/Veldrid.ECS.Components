namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class RasterizerStateDescriptionComponentFactory : IRasterizerStateDescriptionComponentFactory
    {
        public RasterizerStateDescriptionComponentFactory()
        {
        }

        public RasterizerStateDescriptionComponent Create()
        {
            RasterizerStateDescriptionComponent component = default;

            try
            {
                component = new RasterizerStateDescriptionComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}