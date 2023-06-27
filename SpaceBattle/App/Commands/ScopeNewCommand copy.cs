using System.Threading;
using SpaceBattle.Interface;

namespace SpaceBattle.Commands
{
    public class ScopeCurrentCommand : ICommand
    {
        private string _scopeId;
        public ScopeCurrentCommand()
        {
            this._scopeId = Thread.CurrentThread.ManagedThreadId.ToString();
        }

        public void Execute()
        {
           /* var ThreadName = ThreadLocal<string>( () => { return Thread.GetCurrentProcessorId.CurrentThread.ManagedThreadId.ToString(); } );

            // Action that prints out ThreadName for the current thread
            Action action = () =>
            {
                // If ThreadName.IsValueCreated is true, it means that we are not the
                // first action to run on this thread.
                bool repeat = ThreadName.IsValueCreated;

                Console.WriteLine("ThreadName = {0} {1}", ThreadName.Value, repeat ? "(repeat)" : "");
            };

            // Launch eight of them.  On 4 cores or less, you should see some repeat ThreadNames
            Parallel.Invoke(action);*/
        }
    }
}