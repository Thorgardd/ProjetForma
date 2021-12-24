namespace ProjetForma.Users
{
    public class Admin : User
    {
        public Admin(int pid, string name, string password, bool isAdmin = true)
        {
            Pid = pid;
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }

        private void AddUser(int pidTmp, string nameTmp, string passwordTmp, bool isAdminTmp)
        {

        }

        private void ValidateRegistration(bool validate)
        {

        }

        private void DeleteUser(int pidTmp)
        {

        }
    }
}
