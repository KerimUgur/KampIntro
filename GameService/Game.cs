using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class Game : ICustomer
    {
        public string Name { get; set; }
        public double GameCost { get; set; }
    }
}
