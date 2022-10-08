using System.Collections.Generic;

namespace GameSnake.UserServices
{
    static class UserInitializer
    {
        public static List<User> GetSampleUserData()
        {
            List<User> users = new List<User>();

            users.Add(new User { Name = "Professional User", Score = 250 });
            users.Add(new User { Name = "Test User", Score = 124 });

            return users;
        }
    }
}
