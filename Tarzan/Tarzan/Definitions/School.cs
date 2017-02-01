using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarzan.Definitions
{
    class School
    {
        protected readonly string schoolName;
        protected readonly string postcode;
        protected readonly IList<Vacancy> vacancies = new List<Vacancy>();
        protected readonly IList<Contact> contacts = new List<Contact>();

        public School()
        {

        }

    }
}
