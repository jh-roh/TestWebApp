namespace TestWebApp.DotNetNote.Models.User
{
    public interface IUserRepository
    {
        void AddUser(string userID, string passwrod);

        UserViewModel GetUserByUserID(string userID);

        bool IsCorrectUser(string userID, string password);
        void ModifyUser(int uid, string userId, string password);
    }
}
