using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarzan.Definitions
{
    interface SchoolFactory
    {

        SchoolCollection GetAllSchoolsInAreas(string[] outcodes);

        School CreateSchool(string name, string postcode);
    }
}
