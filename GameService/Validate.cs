using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class Validate : IValidateManager
    {
        public void Validate1(Player player)
        {
            if (player.Username == player.Name&& player.Password == player.TC) 
            {
                Console.WriteLine("Giriş yapılıyor");
            }
            else
            {
                Console.WriteLine("Yanlış bilgi girildi.");

            }
        }

        void IValidateManager.Validate(Customer customer)
        {
            

        }
    }
}
