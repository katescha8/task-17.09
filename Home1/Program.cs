using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Home2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1");
            //Студент студент1 = new Студент();
            //Студент студент2 = new Студент();
            //Студент студент3 = new Студент();
            //Студент студент4 = new Студент();
            //Студент студент5 = new Студент();
            //студент1.Фамилия = "Иванов";
            //студент1.Имя = "Евгений";
            //студент1.Идентификатор = 2201;
            //студент1.Дата_Рождения = "01.10.2003";
            //студент1.степень = Категория_алкоголизма.a;
            //студент1.Объём_выпитого = 1.5;

            //студент2.Фамилия = "Петров";
            //студент2.Имя = "Николай";
            //студент2.Идентификатор = 2202;
            //студент2.Дата_Рождения = "15.04.2003";
            //студент2.степень = Категория_алкоголизма.b;
            //студент2.Объём_выпитого = 1;

            //студент3.Фамилия = "Садоров";
            //студент3.Имя = "Алексей";
            //студент3.Идентификатор = 2203;
            //студент3.Дата_Рождения = "21.05.2004";
            //студент3.степень = Категория_алкоголизма.c;
            //студент3.Объём_выпитого = 0.75;

            //студент4.Фамилия = "Ромашкина";
            //студент4.Имя = "Елизавета";
            //студент4.Идентификатор = 2204;
            //студент4.Дата_Рождения = "24.12.2003";
            //студент4.степень = Категория_алкоголизма.d;
            //студент4.Объём_выпитого = 0;

            //студент5.Фамилия = "Корюшкина";
            //студент5.Имя = "Авдотья";
            //студент5.Идентификатор = 2201;
            //студент5.Дата_Рождения = "16.07.2000";
            //студент5.степень = Категория_алкоголизма.a;
            //студент5.Объём_выпитого = 3.5;
            //double всего_алкоголя = студент1.Объём_выпитого + студент2.Объём_выпитого + студент3.Объём_выпитого + студент4.Объём_выпитого + студент5.Объём_выпитого;
            //double процент1 = Math.Round((студент1.Объём_выпитого * 100) / всего_алкоголя, 1);
            //double процент2 = Math.Round((студент2.Объём_выпитого * 100) / всего_алкоголя, 1);
            //double процент3 = Math.Round((студент3.Объём_выпитого * 100) / всего_алкоголя, 1);
            //double процент4 = Math.Round((студент4.Объём_выпитого * 100) / всего_алкоголя, 1);
            //double процент5 = Math.Round((студент5.Объём_выпитого * 100) / всего_алкоголя, 1);
            //Console.WriteLine($"Всего алкоголя выпито {всего_алкоголя} литров, из них {процент1}% выпил(а) {студент1.Имя},  из них {процент2}% выпил(а) {студент2.Имя}, из них {процент3}% выпил(а) {студент3.Имя}, из них {процент4}% выпил(а) {студент4.Имя}, из них {процент5}% выпил(а) {студент5.Имя}");
            //Console.WriteLine("Задание 2");
            //Console.WriteLine($"sbyte-({SByte.MaxValue})-({SByte.MinValue})");
            //Console.WriteLine($"byte-({Byte.MaxValue})-({Byte.MinValue})");
            //Console.WriteLine($"short-({short.MaxValue})-({short.MinValue})");
            //Console.WriteLine($"ushort-({ushort.MaxValue})-({ushort.MinValue})");
            //Console.WriteLine($"int-({Int32.MaxValue})-({Int32.MinValue})");
            //Console.WriteLine($"uint-({UInt32.MaxValue})-({UInt32.MinValue})");
            //Console.WriteLine($"long-({long.MaxValue})-({long.MinValue})");
            //Console.WriteLine($"ulong-({ulong.MaxValue})-({ulong.MinValue})");
            //Console.WriteLine($"char-({char.MaxValue})-({char.MinValue})");
            //Console.WriteLine($"float-({float.MaxValue})-({float.MinValue})");
            //Console.WriteLine($"double-({Double.MaxValue})-({Double.MinValue})");
            //Console.WriteLine($"decimal-({Decimal.MaxValue})-({Decimal.MinValue})");
            //Console.WriteLine("bool-(True=1)-(False=0)");
            //Console.WriteLine("string-(Строка символов Unicode)");
            //Console.WriteLine("object-(Прародитель всех встроенных и пользовательских типов)");
            //Console.WriteLine("Задание 3");
            //User user1 = new User();
            //Console.Write("Введите своё имя ");
            //user1.name = Console.ReadLine();
            //Console.Write("Введите свой город ");
            //user1.city = Console.ReadLine();
            //Console.Write("Введите свой возраст ");
            //user1.age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите свой PIN-код ");
            //user1.pin_code = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine($"Информация о пользователе {user1.name}: город {user1.city}, возраст {user1.age} лет, PIN-код {user1.pin_code}");
            //Console.WriteLine("Задание 4");
            //Console.Write("Введите имя ");
            //string s1 = Console.ReadLine();
            //int index = s1.IndexOf(' ');
            //string s3 = s1.Remove(index);
            //string s2 = s1.Remove(0, index + 1);
            //string s4 = s2.Remove(1);
            //string s5 = s3.Remove(1);
            //Console.WriteLine(s5 + "."+ s4 + ".");
            //Console.WriteLine("Задание 5");
            //Console.Write("Введите стандартную цену виски ");
            //int normPrice = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите скидку в DutyFree в процентах ");
            //int salePrice = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите стоимость отпуска ");
            //int holidayPrice = Convert.ToInt32(Console.ReadLine());
            //double sale = salePrice * normPrice * 0.01;
            //double amount1 = holidayPrice / sale;
            //double amount2 = Math.Floor(amount1);
            //Console.WriteLine("Вы должны купить " + amount2 + " бутылок");
            //Console.WriteLine("Задание 6");
            //Console.Write("Введите скорость в км/ч ");
            //double speed_km_p_h = Convert.ToDouble(Console.ReadLine());
            //double speed_sm_p_s = Math.Floor(speed_km_p_h / 0.036);
            //Console.WriteLine(speed_km_p_h + " -> " + speed_sm_p_s);
            //Console.WriteLine("Задание 7");
            //Console.Write("Введите строку ");
            //string s1 = Console.ReadLine();
            //char[] char1 = s1.ToCharArray();
            //for (int i = 0; i < char1.Length; i++)
            //{
            //    if (char.IsLower(char1[i]))
            //    {
            //        char1[i] = Char.ToUpper(char1[i]);
            //    }
            //    else
            //    {
            //        char1[i] = Char.ToLower(char1[i]);
            //    }
            //}
            //for (int i = 0; i < char1.Length; i++)
            //{ Console.Write(char1[i]); }
        }
    }
    struct Студент
    {
        public string Фамилия;
        public string Имя;
        public int Идентификатор;
        public string Дата_Рождения;
        public Категория_алкоголизма степень;
        public double Объём_выпитого;
    }
    enum Категория_алкоголизма
    {
        a, //студент-алкоголик
        b, //студент-любитель выпить, но не алкоголик
        c, //студент пьет по праздникам
        d  //студент не пьет
    }
    struct User
    {
        public string name;
        public string city;
        public int age;
        public uint pin_code;

    }
}