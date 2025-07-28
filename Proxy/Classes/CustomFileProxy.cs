using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class CustomFileProxy : IFile
    {
        private readonly FileService _fileService;
        private readonly Dictionary<string, CustomFile> _cache;

        public CustomFileProxy(FileService service)
        {
            _fileService = service;
            _cache = new Dictionary<string, CustomFile>();
        }

        public CustomFile Open(string path, string password)
        {
           if (_cache.ContainsKey(path) == false)
           {
                _cache.Add(path, (_fileService.Open(path, password)));
                return _cache[path];
           }
           if (_cache[path].CheckPassword(password)) return _cache[path]; else throw new Exception("неверный пароль");
           
        }
    }
}
