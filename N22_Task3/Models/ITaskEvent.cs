namespace N22_Task3.Models;

public interface ITaskEvent
{
    Guid Id { get; }
    string Name { get; }
    byte Priority { get; }
}