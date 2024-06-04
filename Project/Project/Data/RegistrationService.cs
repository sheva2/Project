namespace Project.Data
{
    public class RegistrationService
    {
        
        public bool Registration(string email, string login, string password, string repeatPassword)
        {
            bool key = false;
            User user;
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(repeatPassword))
            {
                if (password == repeatPassword)
                {
                    List<User> users = DBRequest.Select<User>("Users", new List<QueryParametr> { new QueryParametr($"[Email]='{email}'", Operator.NONE) });
                    if (users.Count == 0)
                    {
                        users = DBRequest.Select<User>("Users", new List<QueryParametr> { new QueryParametr($"[Login]='{login}'", Operator.NONE) });
                        if (users.Count == 0)
                        {
                            user = new User(login,Cryptographer.Encrypt(password),email);
                            int id=DBRequest.Insert("Users", user,true);
                            key = true;
                            user.Id= id;
                            UserService.getInstance(user);
                        }
                    }
                }
            }
            return key; 
        }
        public bool Authorization(string emailLogin, string password)
        {
            bool key = false;
            string encryptPassword;
            List<User> users;
            if(!string.IsNullOrEmpty(emailLogin) && !string.IsNullOrEmpty(password))
            {
                encryptPassword= Cryptographer.Encrypt(password);
                List<QueryParametr> parametrs = new List<QueryParametr>
                {
                    new QueryParametr($"([Login]='{emailLogin}' and [Password]='{encryptPassword}')",Operator.OR),
                    new QueryParametr($"([Email]='{emailLogin}' and [Password]='{encryptPassword}')",Operator.NONE)
                };
                users = DBRequest.Select<User>("Users", parametrs);
                if(users.Count != 0)
                {
                    var blockedUser = DBRequest.Select<BlockedUser>("BlockedUsers", new List<QueryParametr> { new QueryParametr($"[UserId]={users[0].Id}", Operator.NONE) });
                    if (blockedUser.Count == 0)
                    {
                        UserService.getInstance(users[0]);

                        key = true;
                    }
                }
            }
            return key;
        }
    }
}
