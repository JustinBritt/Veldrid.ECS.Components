namespace Veldrid.ECS.Components.Structs
{
    using Veldrid;

    public struct CommandListComponent
    {
        public CommandListComponent(
            CommandList value)
        {
            this.Value = value;
        }

        public CommandList Value { get; }
    }
}