namespace Veldrid.ECS.Components.Factories
{
    using Veldrid.ECS.Components.InterfacesFactories;
    using Veldrid.ECS.Components.Structs;

    internal sealed class CommandListComponentFactory : ICommandListComponentFactory
    {
        public CommandListComponentFactory()
        {
        }

        public CommandListComponent Create()
        {
            CommandListComponent component = default;

            try
            {
                component = new CommandListComponent();
            }
            finally
            {
            }

            return component;
        }
    }
}