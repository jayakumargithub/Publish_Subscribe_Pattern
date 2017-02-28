using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.Domain;
using My.Service;

namespace My.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Email = "jayakumar.m.h@gmail.com",
                FirstName = "Jayakumar",
                LastName = "Mogenahalli",
                Id = 1,
                MobileNo = 12345678
            };

            //publisher
            UserService userService = new UserService();

            //subscribers
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

           
            userService.UserCreated += mailService.OnUserCreated;
            userService.UserCreated += messageService.OnUserCreated;

            userService.CreateUser(user);
            Console.ReadLine();
        }
    }
}
