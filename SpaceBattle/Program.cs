using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceBattle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ioc = new IoC();
            /*RegisteredDependency<Vector> a = (args) => new Vector(12, 5);
            var v = a();
            Console.WriteLine(v);

            Console.WriteLine("register Vector");
            ioc.Resolve<Vector>("IoC.Register", "Vector", (args) => new Vector((int)args[0], (int)args[1])).Execute();

            Console.WriteLine("get Vector");
            var v2 = ioc.Resolve<Vector>("Vector", 10, 5);            
            Console.WriteLine(v2);*/

            /*ioc.Resolve<ScopeNewCommand>("IoC.Register", "Scopes.New", (args) => new ScopeNewCommand((int)args[0])).Execute();

            ioc.Resolve<ICommand>(
                "Scopes.New", 
                new ThreadLocal<int>(() => {
                    return Thread.CurrentThread.ManagedThreadId;
                    })
                );*/

            ThreadLocal<Hashtable> ThreadName = new ThreadLocal<Hashtable>(() =>
            {
                return new Hashtable()
                {
                    { Thread.CurrentThread.ManagedThreadId, $"thread {Thread.CurrentThread.ManagedThreadId}" }
                };
            });

            foreach (DictionaryEntry threadName in ThreadName.Value)
            {
                Console.WriteLine($"{threadName.Key}: {threadName.Value}");
            }


            // Action that prints out ThreadName for the current thread
            Action action = () =>
            {
                // If ThreadName.IsValueCreated is true, it means that we are not the
                // first action to run on this thread.
                bool repeat = ThreadName.IsValueCreated;

                Console.WriteLine("ThreadName = {0} {1}", Thread.CurrentThread.ManagedThreadId, repeat ? "(repeat)" : "");
            };

            // Launch eight of them.  On 4 cores or less, you should see some repeat ThreadNames
            Parallel.Invoke(action, action, action);

            foreach (DictionaryEntry threadName in ThreadName.Value)
            {
                Console.WriteLine($"{threadName.Key}: {threadName.Value}");
            }

            // Dispose when you are done
            ThreadName.Dispose();
        }
    }
}