namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IDepthStencilStateDescriptionComponentFactory
    {
        DepthStencilStateDescriptionComponent Create(
            DepthStencilStateDescription value);
    }
}