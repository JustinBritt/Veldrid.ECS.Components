namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface IViewportComponentFactory
    {
        ViewportComponent Create(
            Viewport value);
    }
}