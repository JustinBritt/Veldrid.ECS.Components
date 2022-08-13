namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct RasterizerStateDescriptionComponent
    {
        public RasterizerStateDescriptionComponent(
            RasterizerStateDescription value)
        {
            this.Value = value;
        }

        public RasterizerStateDescription Value { get; }
    }
}