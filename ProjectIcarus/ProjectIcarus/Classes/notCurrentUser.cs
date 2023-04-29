using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIcarus.Classes
{
    internal class notCurrentUser
    {
        private static notCurrentUser user = null;

        protected notCurrentUser()
        {

        }

        public static notCurrentUser Initialize()
        {
            if (user == null)
            {
                user = new notCurrentUser();
            }

            return user;
        }

        public int ID
        {
            get { return user.id; }
            set { user.id = value; }
        }

        private int id;
    }
}
