using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command.Classes
{
    public class WriteTextCommand : Command.Interfaces.ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _newText;
        private readonly int _line;
        public WriteTextCommand(Receiver textEditor, string newText)
        {
            _receiver = textEditor;
            _line = _receiver.text.Length;
            _newText = newText;
        }

        public void Execute()
        {
            _receiver.AddText(_newText);
        }
        public void Undo()
        {
            _receiver.text = _receiver.text.Substring(0, _line);
        }

    }
}
