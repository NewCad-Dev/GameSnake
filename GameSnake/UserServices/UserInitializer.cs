using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake.UserServices
{
    static class UserInitializer
    {
        public static List<User> GetSampleUserData()
        {
            List<User> users = new List<User>();

            users.Add(new User { Name = "Same Name", Score = 123 });
            users.Add(new User { Name = "Same Name2", Score = 124 });
            users.Add(new User { Name = "Same Name", Score = 3 });

            return users;
        }
    }
}
