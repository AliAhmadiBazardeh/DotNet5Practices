using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet5Practices.Models;

namespace DotNet5Practices.Services
{
   public interface IUser
   {
       List<Users> GetAll();
   }

    public class UserServices : IUser
    {
        public List<Users> GetAll()
        {
            return new List<Users>()
            {
                new Users() {Name = "Ali Ahmadi"},
                new Users() {Name = "Fatemeh Ahmadi"},
                new Users() {Name = "Hossein Ahmadi"}
            };
        }
    }
}
