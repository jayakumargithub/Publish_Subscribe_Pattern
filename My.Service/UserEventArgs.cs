using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.Domain;

namespace My.Service
{
    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
    }
}
