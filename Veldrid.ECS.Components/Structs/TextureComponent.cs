namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct TextureComponent
    {
        public TextureComponent(
            Texture value)
        {
            this.Value = value;
        }

        public Texture Value { get; set; }
    }
}