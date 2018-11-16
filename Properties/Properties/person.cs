using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class person
    {
        private string _firstname;
        private string _lastname;
        private string _fullname;


        //u can create property only to private
        //the name of the property is Firstname

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }

        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;

            }
        }

        public string FullName
        {
            get
            {
                return _firstname + _lastname;
            }
        }
    }
}