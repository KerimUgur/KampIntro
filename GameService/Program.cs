using System;
using System.Collections.Generic;

namespace GameService
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidateManager validateManager = new Validate();

            ICustomerManager playermanager = new PlayerManager(new List<IValidateManager> { validateManager });
            Customer customer1 = new Customer() { Name = "Kerim", LastName = "Uğur", TC = "40450194096", BirthYear = "2001" };
            Customer customer2 = new Customer() { Name = "Aykut", LastName = "Yavuz", TC = "40450546521", BirthYear = "2000" };
            Customer customer3 = new Customer() { Name = "Selçuk", LastName = "Koç", TC = "78945613278", BirthYear = "1999" };

            playermanager.Add(customer1);
            playermanager.Add(customer2);
            playermanager.Add(customer3);

            ICustomer RocketLeague = new Game() { Name = "Rocket League", GameCost = 18 };
            ICustomer ShadowOfWar = new Game() { Name = "Shadow Of War", GameCost = 17.85 };
            ICustomer PayDay = new Game() { Name = "PayDay", GameCost = 2.75 };

            ICustomerManager gameManager = new GameManager();
            gameManager.Add(ShadowOfWar);
            gameManager.Add(PayDay);
            gameManager.Add(RocketLeague);

            ISaleManager greatSaleWeek = new GreatSaleWeek();

            IPlatformManager origin = new OriginPlatform(greatSaleWeek);

            origin.GameSelling(customer1, ShadowOfWar);
            origin.GameSelling(customer2, RocketLeague);
            origin.GameSelling(customer3, PayDay);



        }
    }
}
