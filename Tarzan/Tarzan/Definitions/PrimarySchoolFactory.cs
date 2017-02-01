using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarzan.Definitions
{
    class PrimarySchoolFactory : SchoolFactory
    {
        public School CreateSchool(string name, string postcode)
        {
            throw new NotImplementedException();
        }

        public SchoolCollection GetAllSchoolsInAreas(string[] outcodes)
        {
            throw new NotImplementedException();
        }
    }
}
