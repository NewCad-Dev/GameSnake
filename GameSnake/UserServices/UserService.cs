using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake.UserServices
{
    class UserService
    {
        List<User> _users;

        public UserService()
        {
            _users = UserInitializer.GetSampleUserData();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users.OrderByDescending(x => x.Score);
        }

        public User CreateUser(string name)
        {
            User user = new User();
            user.Name = name;

            _users.Add(user);

            return user;
        }
    }
}
