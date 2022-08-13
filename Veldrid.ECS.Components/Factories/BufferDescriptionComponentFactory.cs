namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class BufferDescriptionComponentFactory : IBufferDescriptionComponentFactory
    {
        public BufferDescriptionComponentFactory()
        {
        }

        public BufferDescriptionComponent Create()
        {
            BufferDescriptionComponent component = default;

            try
            {
                component = new BufferDescriptionComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}