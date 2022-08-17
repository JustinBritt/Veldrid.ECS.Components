namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct TextureViewComponent
    {
        public TextureViewComponent(
            TextureView value)
        {
            this.Value = value;
        }

        public TextureView Value { get; set; }
    }
}