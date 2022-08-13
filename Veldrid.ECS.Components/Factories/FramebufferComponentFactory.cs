namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class FramebufferComponentFactory : IFramebufferComponentFactory
    {
        public FramebufferComponentFactory()
        {
        }

        public FramebufferComponent Create()
        {
            FramebufferComponent component = default;

            try
            {
                component = new FramebufferComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}