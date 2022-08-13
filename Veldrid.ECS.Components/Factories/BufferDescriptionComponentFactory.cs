namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class BufferDescriptionComponentFactory : IBufferDescriptionComponentFactory
    {
        public BufferDescriptionComponentFactory()
        {
        }

        public BufferDescriptionComponent Create(
            BufferDescription value)
        {
            BufferDescriptionComponent component = default;

            try
            {
                component = new BufferDescriptionComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}