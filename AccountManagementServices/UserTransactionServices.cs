using ClassroomManagementData;
using ClassroomManagementModels;

namespace ClassroomManagementServices
{
    public class UserTransactionServices
    {
        UserValidationServices validationServices = new UserValidationServices();
        UserData userData = new UserData();

        public bool CreateUser(User user)
        {
            bool result = validationServices.CheckIfUserNameExists(user.prof);

            if (result)
            {
                userData.AddUser(user);
            }

            return result ;
        }

        public bool UpdateUser(User user)
        {
            bool result = validationServices.CheckIfUserNameExists(user.prof);

            if (result)
            {
                userData.UpdateUser(user);
            }

            return result;
        }


    }
}
