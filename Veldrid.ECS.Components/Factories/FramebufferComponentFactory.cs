namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class FramebufferComponentFactory : IFramebufferComponentFactory
    {
        public FramebufferComponentFactory()
        {
        }

        public FramebufferComponent Create(
            Framebuffer value)
        {
            FramebufferComponent component = default;

            try
            {
                component = new FramebufferComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}