using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Service
{
    /// <summary>
    ///  
    /// </summary>
    public class MailService
    {
        /// <summary>
        /// Subscriber to UserCreation -> delegate match
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        public void OnUserCreated(object source, UserEventArgs args)
        {
            Console.WriteLine("MailService:Email sending to :" + args.User.Email);
        }
    }
}
