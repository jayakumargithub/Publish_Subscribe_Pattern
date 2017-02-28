using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using My.Domain;

namespace My.Service
{

    public class UserService
    {
        //public delegate void UserCreatedEventHandler(object source, UserEventArgs args);
        //public event UserCreatedEventHandler UserCreated;

        public event EventHandler<UserEventArgs> UserCreated;

        public void CreateUser(User user)
        {

            Console.WriteLine("UserCreated....!!");
            Thread.Sleep(5000);
            OnUserCreated(user);

        }

        protected virtual void OnUserCreated(User user)
        {
            UserCreated?.Invoke(this, new UserEventArgs() {User = user});
        }
    }
}
