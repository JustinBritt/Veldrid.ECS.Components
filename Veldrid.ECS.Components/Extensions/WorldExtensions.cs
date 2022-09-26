namespace Veldrid.ECS.Components.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public static class WorldExtensions
    {
        public static Framebuffer GetFramebufferLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<FramebufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<FramebufferComponent>().Value)
                .Last();
        }

        public static GraphicsDevice GetGraphicsDeviceLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<GraphicsDeviceComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<GraphicsDeviceComponent>().Value)
                .Last();
        }

        public static ref ViewportComponent GetViewportComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<ViewportComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<ViewportComponent>();
        }

        public static Viewport GetViewportLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<ViewportComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<ViewportComponent>().Value)
                .Last();
        }
    }
}