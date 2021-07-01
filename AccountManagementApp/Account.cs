using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {
        private string owner;
        private int accountNum;
        private double balance;
   
    public Account(string ow, int acNum, double bal)
    {
        owner = ow;
        accountNum = acNum;
        balance = bal;
    }

    public bool withdraw(double amt)
    {
            if(amt <= balance)
            {
                balance = balance - amt;

                return true;
            }
                return false;
    }
    public bool deposit(double amt)
    {
            if (amt > 0)
            {
                balance = balance + amt;
                return true;
            }
            else
            {
                return false;
            }
    }

    public bool transfer(Account other, double amt)
    {
        if (withdraw(amt))
            {
                other.deposit(amt);
                return true;
            }
        return false;
    }
        
    public string toString()
    {
        string s = "Owner: " + owner + "\nAccNumber:" + accountNum + "\nBalance: " + balance;
        s = s + "\n"; 

        return s;
    }
    }
}
