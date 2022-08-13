namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class TextureViewComponentFactory : ITextureViewComponentFactory
    {
        public TextureViewComponentFactory()
        {
        }

        public TextureViewComponent Create(
            TextureView value)
        {
            TextureViewComponent component = default;

            try
            {
                component = new TextureViewComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}