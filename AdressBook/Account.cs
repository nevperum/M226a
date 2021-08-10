using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Account
    {

        protected string _emailAddresses;
        protected int _name;

        public int Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string EmailAddresses
        {
            get { return _emailAddresses; }
            set { _emailAddresses = value; }
        }

    }
}
