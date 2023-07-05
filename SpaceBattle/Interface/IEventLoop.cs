using System;
using SpaceBattle.Interface;

namespace SpaceBattle;

public interface IEventLoop
{
    void CompleteAdding();
    bool IsCompleted { get; }
    bool Add(ICommand command);
    bool Take(out ICommand command);
    Func<bool> StopSignal { get; set; }
    int Count { get; }
}