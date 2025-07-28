using Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface IUserBuilder
    {
        public IUserBuilder SetUsername(string s);
        public IUserBuilder SetPassword(string s);
        public IUserBuilder SetEmail(string s);
        public IUserBuilder SetPhone(string s);
        public IUserBuilder SetAddress(string s);
        public IUserBuilder SetBirthDate(DateTime? s);
        public User Build();
    }
}
