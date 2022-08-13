namespace Veldrid.ECS.Components.Factories
{
    using Veldrid;
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class CommandListComponentFactory : ICommandListComponentFactory
    {
        public CommandListComponentFactory()
        {
        }

        public CommandListComponent Create(
            CommandList value)
        {
            CommandListComponent component = default;

            try
            {
                component = new CommandListComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}