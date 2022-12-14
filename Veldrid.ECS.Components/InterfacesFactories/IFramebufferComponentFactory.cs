namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IFramebufferComponentFactory
    {
        FramebufferComponent Create(
            Framebuffer value);
    }
}