using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class PlayerManager : ICustomerManager
    {
        List<IValidateManager> _validateManagers;

        public PlayerManager(List<IValidateManager> validateManagers)
        {
            _validateManagers = validateManagers;
        }
        public void Add(ICustomer customer)
        {
            Console.WriteLine(customer.Name + " Oyuncusu eklendi.");
        }

        public void Delete(ICustomer customer)
        {
            Console.WriteLine(customer.Name + " Oyuncu silindi.");
        }

        public void Update(ICustomer customer)
        {
            Console.WriteLine(customer.Name + " Oyuncu güncellendi.");
        }
    }
}
