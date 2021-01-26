using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    interface ICustomerManager
    {
        void Add(ICustomer customer);
        void Delete(ICustomer customer);
        void Update(ICustomer customer);
    }
}
