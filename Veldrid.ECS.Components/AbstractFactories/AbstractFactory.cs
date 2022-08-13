namespace Veldrid.ECS.Components.AbstractFactories
{
    using Veldrid.ECS.Components.Factories;
    using Veldrid.ECS.Components.InterfacesAbstractFactories;
    using Veldrid.ECS.Components.InterfacesFactories;

    public sealed class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public static IAbstractFactory Create()
        {
            return new AbstractFactory();
        }

        public IBlendStateDescriptionComponentFactory CreateBlendStateDescriptionComponentFactory()
        {
            IBlendStateDescriptionComponentFactory factory = null;

            try
            {
                factory = new BlendStateDescriptionComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IBufferDescriptionComponentFactory CreateBufferDescriptionComponentFactory()
        {
            IBufferDescriptionComponentFactory factory = null;

            try
            {
                factory = new BufferDescriptionComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ICommandListComponentFactory CreateCommandListComponentFactory()
        {
            ICommandListComponentFactory factory = null;

            try
            {
                factory = new CommandListComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IDepthStencilStateDescriptionComponentFactory CreateDepthStencilStateDescriptionComponentFactory()
        {
            IDepthStencilStateDescriptionComponentFactory factory = null;

            try
            {
                factory = new DepthStencilStateDescriptionComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IFramebufferComponentFactory CreateFramebufferComponentFactory()
        {
            IFramebufferComponentFactory factory = null;

            try
            {
                factory = new FramebufferComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGraphicsDeviceComponentFactory CreateGraphicsDeviceComponentFactory()
        {
            IGraphicsDeviceComponentFactory factory = null;

            try
            {
                factory = new GraphicsDeviceComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IRasterizerStateDescriptionComponentFactory CreateRasterizerStateDescriptionComponentFactory()
        {
            IRasterizerStateDescriptionComponentFactory factory = null;

            try
            {
                factory = new RasterizerStateDescriptionComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ITextureComponentFactory CreateTextureComponentFactory()
        {
            ITextureComponentFactory factory = null;

            try
            {
                factory = new TextureComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ITextureViewComponentFactory CreateTextureViewComponentFactory()
        {
            ITextureViewComponentFactory factory = null;

            try
            {
                factory = new TextureViewComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IViewportComponentFactory CreateViewportComponentFactory()
        {
            IViewportComponentFactory factory = null;

            try
            {
                factory = new ViewportComponentFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}