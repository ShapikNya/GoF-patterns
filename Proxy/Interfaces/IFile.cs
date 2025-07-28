using Proxy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interfaces
{
    public interface IFile
    {
       public CustomFile? Open(string path, string password);
    }
}
