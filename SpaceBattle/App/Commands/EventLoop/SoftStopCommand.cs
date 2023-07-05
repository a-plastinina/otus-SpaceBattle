using System;
using System.Threading;
using SpaceBattle.Interface;

namespace SpaceBattle;

public class SoftStopCommand: ICommand
{
    private readonly IEventLoop _list;

    public SoftStopCommand(IEventLoop list)
    {
        _list = list;
        Console.WriteLine(@$"              {Thread.CurrentThread.ManagedThreadId} : create SOFT command");
    }
    public void Execute()
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : Soft STOP command, count = {_list.Count}");
        _list.CompleteAdding();
        _list.StopSignal = () => _list.IsCompleted;
        Console.WriteLine($"count = {_list.Count}");
    }
}