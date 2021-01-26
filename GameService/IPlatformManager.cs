using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    interface IPlatformManager
    {
        void GameSelling(ICustomer customer, ICustomer game);
    }
}
