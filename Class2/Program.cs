using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account = BankAccount.Saving;
            Console.WriteLine(account);   
        }
    }
    enum BankAccount
    {
        Current,
        Saving
    }

}