using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIcarus.Classes
{
    internal class CurrentUser
    {
        private static CurrentUser currentUser = null;

        protected CurrentUser()
        {
        
        }

        public static CurrentUser Initialize()
        {
            if (currentUser == null)
            {
                currentUser = new CurrentUser();
            }

            return currentUser;
        }

        public int ID
        {
            get { return currentUser.id; }
            set { currentUser.id = value; }
        }

        private int id;
    }
}
