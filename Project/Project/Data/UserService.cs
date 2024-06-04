using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Project.Data
{
    public class UserService : INotifyPropertyChanged
    {
        private static UserService instance;
        public static UserService getInstance()
        {
            if(instance==null)
                instance = new UserService();
            return instance;
        }
        public static UserService getInstance(User u)
        {
            if (instance == null)
                instance = new UserService();
            instance.curentUser = u;
            return instance;
        }
        public UserService()
        {
            
        }
        
        private  User curentUser=new User("username","",""); 
        public  User CurentUser
        {
            get { return curentUser; }
            set
            {
                curentUser = value;
                OnPropertyChanged("CurentUser");
                
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
