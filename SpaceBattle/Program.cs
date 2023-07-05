using System;
using System.Threading.Tasks;
using SpaceBattle.App.Interface;
using SpaceBattle.Interface;

namespace SpaceBattle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IoC.Resolve<ICommand>("IoC.Register"
                , "EventLoop"
                , (object[] args) => new EventLoop()
            ).Execute();
            
            IoC.Resolve<ICommand>("IoC.Register"
                , "Command.Some"
                , (object[] args) => new SomeCommand((int)args[0])
            ).Execute();
            
            IoC.Resolve<ICommand>("IoC.Register"
                , "Command.Stop.Hard"
                , (object[] args) => new HardStopCommand((IEventLoop)args[0])
            ).Execute();
            
            IoC.Resolve<ICommand>("IoC.Register"
                , "Command.Stop.Soft"
                , (object[] args) => new SoftStopCommand((IEventLoop)args[0])
            ).Execute();
            
            IoC.Resolve<ICommand>("IoC.Register"
                , "Producer"
                , (object[] args) => new Producer((IEventLoop)args[0])
            ).Execute();
            
            IoC.Resolve<ICommand>("IoC.Register"
                , "Command.StartRead"
                , (object[] args) => new StartTaskReadCommand((IEventLoop)args[0])
            ).Execute();
            
            var list = IoC.Resolve<IEventLoop>("EventLoop");
            
            var producer = IoC.Resolve<Producer>("Producer", list);
            var reader = IoC.Resolve<ICommandAsync>("Command.StartRead", list);
            
            var task = reader.Execute();
            for (int i = 0; i < 3; i++)
            {
                producer.Add(IoC.Resolve<ICommand>("Command.Some", i + 20));
                if (i == 2)
                    producer.Add(IoC.Resolve<ICommand>("Command.Stop.Soft", list));
            }
            var task2 = Task.Run(() => producer.Start());
            
            Console.WriteLine(task.Status);
            Console.WriteLine(task2.Status);
            
            Task.WaitAll(task, task2);
            
            Console.WriteLine(task.Status);
            Console.WriteLine(task2.Status);
        }
    }
}