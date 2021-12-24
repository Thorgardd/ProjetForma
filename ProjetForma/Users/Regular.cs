namespace ProjetForma.Users
{
    public class Regular : User
    {
        public Regular(int pid, string name, string password, bool isAdmin = false)
        {
            Pid = pid;
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
