using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AccountManager
    {
        private int maxNumAcc;
        private int numAccounts;
        private Account[] accList;
        public AccountManager(int mx)
        {
            maxNumAcc = mx;
            numAccounts = 0;
            accList = new Account[maxNumAcc];

        }
        public bool addAccount(string ow, int acNum, double bal)
        {
            if(numAccounts < maxNumAcc)
            {
                Account temp = new Account(ow, acNum, bal);
                accList[numAccounts] = temp;
                numAccounts++;
                return true;
            }
            return false;
        }

     
    }
}
