using System;
using System.Threading;
using SpaceBattle.Interface;

namespace SpaceBattle;

public class SomeCommand : ICommand
{
    private readonly int _id;

    public SomeCommand(int id)
    {
        _id = id;
        Console.WriteLine(@$"                {Thread.CurrentThread.ManagedThreadId} : {id} create command {this.GetType()}");
    }
    public void Execute()
    {
        if (new Random().Next(11) % 2 == 0)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {_id} command do something");
        }
        else
        {
            throw new ApplicationException($"{Thread.CurrentThread.ManagedThreadId} : {_id} Random exception");
        }
    }
}