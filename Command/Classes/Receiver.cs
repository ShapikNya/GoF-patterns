using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class Receiver
    {
        private readonly StringBuilder _text = new StringBuilder();
        public string text { get => _text.ToString(); set { _text.Clear(); _text.Append(value); } }

        public void AddText(string newText) => _text.Append(newText);


    }
}
