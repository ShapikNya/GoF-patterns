using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class UserBuilder : IUserBuilder
    {
        private User user = new();
        public IUserBuilder SetUsername(string username)
        {
            user = user with { Username = username };
            return this;
        }
        public IUserBuilder SetPassword(string password)
        {
            user = user with { Password = password };
            return this;
        }
        public IUserBuilder SetEmail(string email)
        {
            user = user with { Email = email };
            return this;
        }
        public IUserBuilder SetPhone(string phone)
        {
            user = user with { Phone = phone };
            return this;
        }
        public IUserBuilder SetAddress(string address)
        {
            user = user with { Address = address };
            return this;
        }
        public IUserBuilder SetBirthDate(DateTime? date )
        {
            user = user with { BirthDate = date };
            return this;
        }
        public User Build() {
            if (string.IsNullOrWhiteSpace(user.Username))
                throw new InvalidOperationException("Username is required.");
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new InvalidOperationException("Password is required.");
            return user;
        }
    }
}
