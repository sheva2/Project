namespace Project.Data
{
    public class User : BDItem
    {
        
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _secondName;
        private string _pantronymic;
        private string _phoneNumber;
        private bool _isCoach;
        private int _avatarId;
        private bool _isAdmin;
        private string _login;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string SecondName { get { return _secondName; } set { _secondName = value; } }
        public string Patronymic { get { return _pantronymic; } set { _pantronymic = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string TelephoneNumber { get { return _phoneNumber;} set { _phoneNumber = value; } }
        public bool IsCoach { get { return _isCoach; } set { _isCoach = value; } }
        public int AvatarId { get { return _avatarId; } set {  _avatarId = value; } }
        public bool IsAdmin { get { return _isAdmin; } set { _isAdmin = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string Login { get { return _login; } set { _login = value; } }
        public User() {}
        public User(string login,string password,string email) {
            this.Email= email;
            this.Login= login;
            this.Password = password;
            this.Name = " ";
            this.SecondName = " ";
            this.Patronymic = " ";
            this.TelephoneNumber = " ";
            this.IsCoach = false;
            this.IsAdmin = false;
            this.AvatarId = 1;
        }
        public override List<BDItemParametr> GetParams()
        {
            List<BDItemParametr> list = new List<BDItemParametr>()
            {
                new BDItemParametr("Id",ParametrType.INT),
                new BDItemParametr("Name",ParametrType.STRING),
                new BDItemParametr("SecondName",ParametrType.STRING),
                new BDItemParametr("Patronymic",ParametrType.STRING),
                new BDItemParametr("Email",ParametrType.STRING),
                new BDItemParametr("TelephoneNumber",ParametrType.STRING),
                new BDItemParametr("IsCoach",ParametrType.BOOL),
                new BDItemParametr("AvatarId",ParametrType.INT),
                new BDItemParametr("IsAdmin",ParametrType.BOOL),
                new BDItemParametr("Password",ParametrType.STRING),
                new BDItemParametr("Login",ParametrType.STRING)
            };
            return list;
        }
    }
}
