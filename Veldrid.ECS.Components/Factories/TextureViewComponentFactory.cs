namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class TextureViewComponentFactory : ITextureViewComponentFactory
    {
        public TextureViewComponentFactory()
        {
        }

        public TextureViewComponent Create()
        {
            TextureViewComponent component = default;

            try
            {
                component = new TextureViewComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}