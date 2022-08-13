namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface ITextureViewComponentFactory
    {
        TextureViewComponent Create(
            TextureView value);
    }
}