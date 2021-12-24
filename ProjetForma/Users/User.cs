namespace ProjetForma.Users
{
    public abstract class User
    {
        private int _pid;
        private string _name;
        private string _password;
        private bool _isAdmin;

        public int Pid
        {
            get => _pid;
            set => _pid = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public bool IsAdmin
        {
            get => _isAdmin;
            set => _isAdmin = value;
        }
    }
}