using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Service
{
    public class MessageService
    {
        public void OnUserCreated(object source, UserEventArgs args)
        {
            Console.WriteLine("Message Service:Message sending" + args.User.MobileNo);
        }
    }
}
