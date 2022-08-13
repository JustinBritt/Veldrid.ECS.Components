namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct FramebufferComponent
    {
        public FramebufferComponent(
            Framebuffer value)
        {
            this.Value = value;
        }

        public Framebuffer Value { get; }
    }
}