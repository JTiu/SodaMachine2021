using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public string walletName;
        public double totalBalanceCoins;
        public List<Coin> Coins = new List<Coin>();
        Coin penny = new Penny();
        Coin nickel = new Nickel();
        Coin dime = new Dime();
        Coin quarter = new Quarter();
        

        //Constructor (Spawner)
        public Wallet(string nameOfWallet)
        {
            walletName = nameOfWallet;
            
            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()
        {
          
        }
    }
}
