using System;
using System.Collections;
using System.Collections.Generic;
using SpaceBattle.Interface;

namespace SpaceBattle
{


    internal class Program
    {
        static IMovable CreateObject()
        {
            return new MovableAdapter(
                new Ship(null, new Vector(1, 3), 3, 8)
            );
        }
        private static void Main(string[] args)
        {
            var moveAdapter = CreateObject();
            Console.WriteLine($"start: {moveAdapter}");

            const int length = 5;
            var queue = new Queue<ICommand>(length);

            for (int i = 0; i < 3; i++)
            {
                queue.Enqueue(new MoveCommand(moveAdapter));
            }

            var errorhandler = new ErrorHandler();
            errorhandler.Setup(
                typeof(MoveCommand),
                typeof(NullReferenceException),
                (ICommand cmd, Exception ex) => queue.Enqueue(new LogCommand(ex, cmd)));

            errorhandler.Setup(
                typeof(RotateCommand),
                typeof(DivideByZeroException),
                (ICommand cmd, Exception ex) => queue.Enqueue(new LogCommand(ex, cmd)));

            object cmd;
            try
            {
                while ((cmd = queue.Dequeue()) != null)
                {
                    try
                    {
                        ((ICommand)cmd).Execute();
                    }
                    catch (Exception e)
                    {
                        errorhandler.Proccess(e, (ICommand)cmd);
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
                return;
            }
        }
    }
}