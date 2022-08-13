namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class TextureComponentFactory : ITextureComponentFactory
    {
        public TextureComponentFactory()
        {
        }

        public TextureComponent Create()
        {
            TextureComponent component = default;

            try
            {
                component = new TextureComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}