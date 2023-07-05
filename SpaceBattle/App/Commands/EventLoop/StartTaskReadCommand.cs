using System;
using System.Threading;
using System.Threading.Tasks;
using SpaceBattle.App.Interface;
using SpaceBattle.Interface;

namespace SpaceBattle;

public class StartTaskReadCommand: ICommandAsync
{
    private readonly IEventLoop _list;
    public StartTaskReadCommand(IEventLoop list)
    {
        _list = list;
    }

    private Task taskForReading;
    public Task Execute()
    {
        taskForReading = Task.Run(() =>
        {
            Console.WriteLine("*** reading ***");
            Console.WriteLine(_list.StopSignal());
            ICommand command = null;
            
            while (!_list.StopSignal())
            {
                try
                {
                    Console.WriteLine("* * * try to read * * *");
                    if (_list.Take(out command))
                    {
                        command.Execute();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : caught exception {e.Message}");
                }
            }
        });
        return taskForReading;
    }
}