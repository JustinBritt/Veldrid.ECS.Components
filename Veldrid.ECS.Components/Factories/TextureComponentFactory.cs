namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class TextureComponentFactory : ITextureComponentFactory
    {
        public TextureComponentFactory()
        {
        }

        public TextureComponent Create(
            Texture value)
        {
            TextureComponent component = default;

            try
            {
                component = new TextureComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}