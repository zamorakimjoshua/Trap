using ClassroomManagementData;
using ClassroomManagementModels;

namespace ClassroomManagementServices
{
    public class UserGetServices
    {
        private List<User> GetAllUsers()
        {
            UserData userData = new UserData();

            return userData.GetUsers();

        }

        public List<User> GetUsersByStatus(int userStatus)
        {
            List<User> usersByStatus = new List<User>();

            foreach (var user in GetAllUsers())
            {
                if (user.status == userStatus)
                {
                    usersByStatus.Add(user);
                }
            }

            return usersByStatus;
        }

        public User GetUser(string username, string roomNum)
        {
            User foundUser = new User();

            foreach (var user in GetAllUsers())
            {
                if (user.prof == username && user.roomNum == roomNum)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

        public User GetUser(string username)
        {
            User foundUser = new User();

            foreach (var user in GetAllUsers())
            {
                if (user.prof == username)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}