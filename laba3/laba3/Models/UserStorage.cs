namespace laba3.Models
{
    public static class UserStorage
    {
        public static readonly List<User> Users = [new("adasd", "s@mail.ru", "12312312312")];

        public static void AddUser(User user)
            => Users.Add(user);

        public static void RemoveUser(User user)
            => Users.Remove(user);

        public static void ChangeUserInfo(
            int userIndex,
            string userName,
            string userEmail,
            string userPhoneNumber)
        {
            Users[userIndex].Username = userName;
            Users[userIndex].Email = userEmail;
            Users[userIndex].PhoneNumber = userPhoneNumber;
        }
    }
}
