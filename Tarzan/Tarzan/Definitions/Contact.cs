using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarzan.Definitions
{
    class Contact
    {
        private readonly string name;
        private readonly IList<string> emailAddresses = new List<string>();
        private readonly IList<string> phoneNumers = new List<string>();

        public Contact(string fullName)
        {
            name = fullName;
        }

        public void AddNumber(string number)
        {
            phoneNumers.Add(number);
        }

        public void AddEmailAddress(string address)
        {
            emailAddresses.Add(address);
        }

        public string Name { get { return name; } }
        public string EmailAddress { get { return emailAddresses[0] ?? ""; } }
        public string PhoneNumber { get { return phoneNumers[0] ?? ""; } }
    }
}
