namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class BlendStateDescriptionComponentFactory : IBlendStateDescriptionComponentFactory
    {
        public BlendStateDescriptionComponentFactory()
        {
        }

        public BlendStateDescriptionComponent Create()
        {
            BlendStateDescriptionComponent component = default;

            try
            {
                component = new BlendStateDescriptionComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}