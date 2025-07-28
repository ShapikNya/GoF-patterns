using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class CustomFile
    {
        public string Path { get; }

        private readonly string _data;

        private readonly string _password;

        public CustomFile(string path, string password)
        {
            Path = path; _password = password;
            _data = "Some inf: " + Path;
        }

        public bool CheckPassword(string password)
        {
            return _password.Equals(password);
        }

        public override string ToString()
        {
            return _data;
        }

    }
}
