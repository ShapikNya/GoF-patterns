using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class Invoker
    {
        private readonly Stack<Command.Interfaces.ICommand> _executed = new();
        private readonly Queue<Command.Interfaces.ICommand> _pending = new();   

        public void ExecuteCommand()
        {
            while (_pending.Count > 0)
            {
                var command = _pending.Dequeue();
                command.Execute(); // Может выбросить исключение
                _executed.Push(command);
            }
        }

        public void AddCommand(Command.Interfaces.ICommand command) => _pending.Enqueue(command);

        public void UndoLast()
        {
            if (_executed.Count > 0)
                _executed.Peek().Undo(); _executed.Pop();
        }
    }
}
