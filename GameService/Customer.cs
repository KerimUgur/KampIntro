using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class Customer : ICustomer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TC { get; set; }
        public string BirthYear { get; set; }

      
    }
}
