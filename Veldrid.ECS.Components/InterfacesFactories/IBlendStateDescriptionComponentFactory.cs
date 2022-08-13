namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IBlendStateDescriptionComponentFactory
    {
        BlendStateDescriptionComponent Create(
            BlendStateDescription value);
    }
}