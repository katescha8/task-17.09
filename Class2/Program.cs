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
            //Console.WriteLine("Упражнение 3.1 ");
            //BankAccount account = new BankAccount();
            //account = BankAccount.сберегательный;
            //Console.WriteLine(account);   
            //Console.WriteLine("Упражнение 3.2 ");
            //Bank bankacc1 = new Bank();
            //bankacc1.number = 101;
            //bankacc1.type = BankAccount.текущий;
            //bankacc1.balance = 1000;
            //Console.WriteLine($"{bankacc1.number} банковский счет относится к типу {bankacc1.type} и содержит баланс {bankacc1.balance}$");
            //Console.WriteLine("Домашнее задание 3.1 ");
            //Работник работник1 = new Работник();
            //Работник работник2 = new Работник();
            //Работник работник3 = new Работник();
            //работник1.имя = "Сергей";
            //работник1.ВУЗ = ВУЗ.КГУ;
            //работник2.имя = "Владимир";
            //работник2.ВУЗ = ВУЗ.КХТИ;
            //работник3.имя = "Алёна";
            //работник3.ВУЗ = ВУЗ.КАИ;
            //Console.WriteLine($"{работник1.имя} работает в {работник1.ВУЗ}, {работник2.имя} работает в {работник2.ВУЗ}, {работник3.имя} работает в {работник3.ВУЗ}");
        }
    }
    enum BankAccount
    {
        текущий,
        сберегательный
    }
    struct Bank
    {
        public int number;
        public BankAccount type;
        public double balance;
    }
    enum ВУЗ {КГУ,КАИ,КХТИ}
    struct Работник
    {
        public string имя;
        public ВУЗ ВУЗ;
    }


}