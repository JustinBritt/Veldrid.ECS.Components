namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct BufferDescriptionComponent
    {
        public BufferDescriptionComponent(
            BufferDescription value)
        {
            this.Value = value;
        }

        public BufferDescription Value { get; set; }
    }
}