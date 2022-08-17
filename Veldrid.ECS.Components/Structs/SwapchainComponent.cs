namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct SwapchainComponent
    {
        public SwapchainComponent(
            Swapchain value)
        {
            this.Value = value;
        }

        public Swapchain Value { get; set; }
    }
}