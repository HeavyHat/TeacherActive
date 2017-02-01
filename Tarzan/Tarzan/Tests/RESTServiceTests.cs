using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tarzan.Definitions;

namespace Tarzan.Tests
{
    [TestFixture]
    class RESTServiceTests
    {
        [Test]
        public void Test_GetUrlFromEndPoint()
        {
            RESTService service = new RESTService("https://maps.googleapis.com/maps/api/place/textsearch/json?");
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["query"] = "Primary School in E1";
            parameters["key"] = "AIzaSyAKp3OYYL_JOPAiLLW0bp6y4IlK8QFa4Tw";
            Console.Out.WriteLine(service.GetRequest(parameters));
            Console.In.Read();
        }
    }
}
