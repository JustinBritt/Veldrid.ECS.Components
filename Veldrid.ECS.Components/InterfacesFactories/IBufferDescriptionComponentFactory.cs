namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IBufferDescriptionComponentFactory
    {
        BufferDescriptionComponent Create(
            BufferDescription value);
    }
}