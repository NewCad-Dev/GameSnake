using System;
using System.Collections.Generic;
using System.Linq;

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

            IEnumerable<string> existUser = _users.Select(x => x.Name);

            try
            {
                if (name == "")
                    throw new ArgumentException("Name is empty");
                if (existUser.Contains(name))
                    throw new ArgumentException("The user exists");
            }
            catch (Exception ex)
            {

                throw ex;
            }

            user.Name = name;

            _users.Add(user);

            return user;
        }

        public void SaveScore(User user)
        {
            if (user.Name == null)
                return;

            _users.Add(user);
        }
    }
}
