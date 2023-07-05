using System;
using System.Threading;
using SpaceBattle.Interface;

namespace SpaceBattle;

public class HardStopCommand: ICommand
{
    private readonly IEventLoop _list;
    
    public HardStopCommand(IEventLoop list)
    {
        _list = list;
        Console.WriteLine(@$"              {Thread.CurrentThread.ManagedThreadId} : create HARD STOP");
    }
    public void Execute()
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : Execute HARD STOP, count= {_list.Count} ");
        _list.CompleteAdding();
        _list.StopSignal = () => true;
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : count= {_list.Count} ");
    }
}