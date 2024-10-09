namespace ClassroomManagementModels
{
    public class User
    {
        public string prof;
        public string roomNum;
        public DateTime dateVerified;
        private DateTime dateCreated = DateTime.Now;
        public DateTime dateUpdated;
        public UserProfile profile;
        public int status;
        public string colorNum;
    }
}