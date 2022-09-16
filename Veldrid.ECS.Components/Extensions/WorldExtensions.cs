namespace Veldrid.ECS.Components.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public static class WorldExtensions
    {
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