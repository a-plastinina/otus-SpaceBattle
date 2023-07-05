using System;
using System.Collections.Concurrent;
using SpaceBattle.Interface;

namespace SpaceBattle;

public class EventLoop : IEventLoop
{
    private readonly BlockingCollection<ICommand> _list = new();
        
    public EventLoop()
    {
        StopSignal = () => false;
    }
    
    public bool IsCompleted => _list.IsCompleted;
    public void CompleteAdding() => _list.CompleteAdding();
        

    public bool Add(ICommand command)
    {
        if (!_list.IsAddingCompleted)
        {
            Console.WriteLine($"add, count= {_list.Count} ");
            return _list.TryAdd(command);
        }

        Console.WriteLine($"try add, count= {_list.Count} ");
        return false;
    }

    public bool Take(out ICommand command)
    {
        return _list.TryTake(out command);
    }
    public Func<bool> StopSignal { get; set; }

    public int Count => _list.Count;
}