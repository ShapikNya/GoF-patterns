using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class FileService : IFile
    {
        private Dictionary<string, CustomFile> _files = new Dictionary<string, CustomFile> { 
            { "/c", new CustomFile  ("/c", "123") },
            { "/c/folder", new CustomFile  ("/c/folder", "321") }
        };

        public CustomFile Open(string path, string password)
        {
            Thread.Sleep(5000);
            if (_files.ContainsKey(path))
            {
                if (_files[path].CheckPassword(password)) { return _files[path]; } else throw new Exception("Неверный пароль");
            }
            else throw new Exception("Такого файла нет");
        }


    }
}
