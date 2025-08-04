namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Ali", Email = "ali@example.com", Phone = "1234567890", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Ahmet", Email = "ahmet@example.com", Phone = "1234567891", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Canan", Email = "canan@example.com", Phone = "1234567892", WillAttend = true });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}