using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class GreatSaleWeek : ISaleManager
    {
        public void Sale(ICustomer game)
        {
            Console.WriteLine(game.Name + "Oyununa indirim uygulandı. ");
        }
    }
}
