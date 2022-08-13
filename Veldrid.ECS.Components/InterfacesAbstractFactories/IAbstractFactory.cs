namespace Veldrid.ECS.Components.InterfacesAbstractFactories
{
    using Veldrid.ECS.Components.InterfacesFactories;

    public interface IAbstractFactory
    {
        IBlendStateDescriptionComponentFactory CreateBlendStateDescriptionComponentFactory();

        IBufferDescriptionComponentFactory CreateBufferDescriptionComponentFactory();

        ICommandListComponentFactory CreateCommandListComponentFactory();

        IDepthStencilStateDescriptionComponentFactory CreateDepthStencilStateDescriptionComponentFactory();

        IFramebufferComponentFactory CreateFramebufferComponentFactory();

        IGraphicsDeviceComponentFactory CreateGraphicsDeviceComponentFactory();

        IRasterizerStateDescriptionComponentFactory CreateRasterizerStateDescriptionComponentFactory();

        ITextureComponentFactory CreateTextureComponentFactory();

        ITextureViewComponentFactory CreateTextureViewComponentFactory();

        IViewportComponentFactory CreateViewportComponentFactory();
    }
}