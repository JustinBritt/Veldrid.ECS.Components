namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface ITextureComponentFactory
    {
        TextureComponent Create(
            Texture value);
    }
}