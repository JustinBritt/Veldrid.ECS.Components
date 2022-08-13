namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct BlendStateDescriptionComponent
    {
        public BlendStateDescriptionComponent(
            BlendStateDescription value)
        {
            this.Value = value;
        }

        public BlendStateDescription Value { get; }
    }
}