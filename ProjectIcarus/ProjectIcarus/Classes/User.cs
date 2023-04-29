using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIcarus.Classes
{
    internal class User
    {
        public User()
        {

        }
        public int id { get; set; }
        public string userName { get; set; }
        public string login { get; set; }
        private string password { get; set; }
        public string profileDescription { get; set; }
    }
}
