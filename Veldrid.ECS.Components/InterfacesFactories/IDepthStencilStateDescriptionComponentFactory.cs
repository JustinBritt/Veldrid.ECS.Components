namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid.ECS.Components.Structs;

    public interface IDepthStencilStateDescriptionComponentFactory
    {
        DepthStencilStateDescriptionComponent Create();
    }
}