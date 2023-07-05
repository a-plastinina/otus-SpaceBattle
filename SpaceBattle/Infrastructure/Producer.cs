using System;
using SpaceBattle.Interface;

namespace SpaceBattle;

internal class Producer
{
    private readonly IEventLoop _list;

    public Producer(IEventLoop list)
    {
        _list = list;
    }

    public void Add(ICommand command)
    {
        try
        {
            if (!_list.IsCompleted)
                _list.Add(command);
        }
        catch (Exception)
        {
            Console.WriteLine("throw exception on adding");
        }
    }

    public void Start()
    {
        int i = 0;
        while (!_list.StopSignal() && i < 10)
        {
            try
            {
                _list.Add(new SomeCommand(i++));
            }
            catch (Exception e)
            {
                Console.WriteLine("error adding command");
            }
            
        }
    }
}