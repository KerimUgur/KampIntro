using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class OriginPlatform : IPlatformManager
    {
        private ISaleManager greatSaleWeek;

        public OriginPlatform(ISaleManager greatSaleWeek)
        {
            this.greatSaleWeek = greatSaleWeek;
        }

        public void GameSelling(ICustomer customer, ICustomer game)
        {
            Console.WriteLine(customer.Name+ " " + game.Name + " Oyununu satın aldı.");
        }
    }
}
