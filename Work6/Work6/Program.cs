using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Work6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("### Menu ###");
            Console.WriteLine("1.Просмотреть");
            Console.WriteLine("2.Записать");
            Console.WriteLine("\n Введите цифру команды");
            char me = char.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int rise = Convert.ToInt32(Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Parse(Console.ReadLine());
            string place = Console.ReadLine();

            switch (me)
            {
                case '2':
                    Data(name, rise, age, date, place);
                    break;
                //case '1':
                //    Method2();
                //    break;
            }
        }

           public static void  Data(string name, int rise, int age, DateTime date, string place )
            {
                Console.WriteLine("Ф.И.О." +name);
                Console.WriteLine("Введите рост:"+rise);
                Console.WriteLine("Введите возраст:"+age);
                Console.WriteLine("Дата рождения:"+date);
                Console.WriteLine("Место рождения:"+place);
            }
       
        public static void Ma()
        {
            string[] str = new string [Main];
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine("str[{0}]={1}", i, str[i]);

        }
            void Method1()
            {
                using (StreamWriter file = new StreamWriter("dir.txt", true, Encoding.UTF8))
                {


                    int id = 1;
                    char key = 'д';
                    do
                    {

                    //Console.WriteLine(id);

                    //Console.WriteLine("Введите Ф.И.О.:");
                    //string name = Console.ReadLine();

                    //string now = DateTime.Now.ToString();
                    //Console.WriteLine(now);

                    //Console.WriteLine("Введите свой рост:");
                    //int rise = int.Parse(Console.ReadLine());

                    //Console.WriteLine("Введите свой возраст:");
                    //int age = int.Parse(Console.ReadLine());

                    //Console.WriteLine("Введите дату рождения:");
                    //DateTime date = DateTime.Parse(Console.ReadLine());

                    //Console.WriteLine("Введите место рождения:");
                    //string place = Console.ReadLine();
                    Ma();

                        //string s = id + "#" + name + "#" + now + "#" + rise + "#" + age + "#" + date + "#" + place + "\n";
                        //file.WriteLine(s);
                        id++;

                        Console.WriteLine("Продолжить н/д?");
                        key = Console.ReadKey(true).KeyChar;

                    }
                    while (char.ToLower(key) == 'д');

                }
            }
            
            void Method2()
            {
                using (StreamReader file = new StreamReader("dir.txt", Encoding.UTF8))
                {
                    //string line;
                    //Console.WriteLine($"{"id"}{"Ф.И.О."}{"Дата написания записи"}{"Рост"}{"Возраст"}{"Дата рождения"}{"Место рождения"}");
                    //while ((line = file.ReadLine()) != null)
                    //{
                    //    string[] data = line.Split('\t');
                    //    Console.WriteLine($"{data[0]} {data[1]}{data[2]}{data[3]}{data[4]}{data[5]}{data[6]}");
                    //}
                    Console.WriteLine(file.ReadToEnd());

                }
            }
           
        
    }
    

    
}
