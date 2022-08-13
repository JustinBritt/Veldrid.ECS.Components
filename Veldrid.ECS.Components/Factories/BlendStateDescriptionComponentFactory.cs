namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class BlendStateDescriptionComponentFactory : IBlendStateDescriptionComponentFactory
    {
        public BlendStateDescriptionComponentFactory()
        {
        }

        public BlendStateDescriptionComponent Create(
            BlendStateDescription value)
        {
            BlendStateDescriptionComponent component = default;

            try
            {
                component = new BlendStateDescriptionComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}