namespace Veldrid.ECS.Components.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    public interface ICommandListComponentFactory
    {
        CommandListComponent Create(
            CommandList value);
    }
}