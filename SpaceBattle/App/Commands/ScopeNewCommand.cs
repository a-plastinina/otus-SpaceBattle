using System;
using System.Threading;
using System.Threading.Tasks;
using SpaceBattle.Interface;

namespace SpaceBattle.Commands
{
    public class ScopeNewCommand : ICommand
    {
        private string _scopeId;
        public ScopeNewCommand(int scopeId)
        {
            this._scopeId = scopeId.ToString();
        }

        public void Execute()
        {
            ThreadLocal<string> ThreadName = new ThreadLocal<string>(() =>
            {
                return "Thread" + Thread.CurrentThread.ManagedThreadId;
            });

            // Action that prints out ThreadName for the current thread
            Action action = () =>
            {
                // If ThreadName.IsValueCreated is true, it means that we are not the
                // first action to run on this thread.
                bool repeat = ThreadName.IsValueCreated;

                Console.WriteLine("ThreadName = {0} {1}", ThreadName.Value, repeat ? "(repeat)" : "");
            };

            // Launch eight of them.  On 4 cores or less, you should see some repeat ThreadNames
            Parallel.Invoke(action);

            // Dispose when you are done
            ThreadName.Dispose();
        }
    }
}