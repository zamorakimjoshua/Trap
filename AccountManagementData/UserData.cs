﻿using ClassroomManagementModels;

namespace ClassroomManagementData
{
    public class UserData
    {
        List<User> users;
        public UserData()
        {
            users = new List<User>();
            UserFactory _userFactory = new UserFactory();
            users = _userFactory.GetDummyUsers();
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
           users.Add(user);
        }

        public void UpdateUser(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].prof == user.prof)
                {
                    users[i].profile = user.profile;
                    users[i].prof = user.prof;
                    users[i].dateUpdated = DateTime.Now;
                }
            }
        }
    }
}
