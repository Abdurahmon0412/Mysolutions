namespace N22_Task3.Models;

public interface IPriorityQueue<TEvent> where TEvent : ITaskEvent
{
    void Enqueue(TEvent eventItem);

    TEvent Dequeue();

    TEvent Peek();
}