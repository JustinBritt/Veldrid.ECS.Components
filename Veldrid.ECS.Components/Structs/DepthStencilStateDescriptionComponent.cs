namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct DepthStencilStateDescriptionComponent
    {
        public DepthStencilStateDescriptionComponent(
            DepthStencilStateDescription value)
        {
            this.Value = value;
        }

        public DepthStencilStateDescription Value { get; }
    }
}