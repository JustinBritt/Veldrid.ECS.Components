namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IRasterizerStateDescriptionComponentFactory
    {
        RasterizerStateDescriptionComponent Create(
            RasterizerStateDescription value);
    }
}