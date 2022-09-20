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
            //Console.WriteLine("sbyte-(127)-(-128)");
            //Console.WriteLine("byte-(255)-(0)");
            //Console.WriteLine("short-(32 767)-(-32 768)");
            //Console.WriteLine("ushort-(65 535)-(0)");
            //Console.WriteLine("int-(2 147 483 647)-(-2 147 483 648)");
            //Console.WriteLine("uint-(4 294 967 295)-(0");
            //Console.WriteLine("long-(9 223 372 036 854 775 807)-(-9 223 372 036 854 775 808)");
            //Console.WriteLine("ulong-(18 446 744 073 709 551 615)-(0)");
            //Console.WriteLine("char-(65 535)-(0)");
            //Console.WriteLine("float-(3,4 x 10^38)-(1,5 x 10^−45)");
            //Console.WriteLine("double-(1.7 x 10^308)-(5 x 10^-324)");
            //Console.WriteLine("decimal-(7,9228 x 10^28)-(1,0 x 10^-28)");
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