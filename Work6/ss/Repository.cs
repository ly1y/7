using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ss
{
    struct Repository
    {
        public Worker[] workers;//массив для хранения данных 
        public string PathFile;//путь к файлу
        int index; //текущий индекс для добавления в массив
        string[] titles; //массив заголовка 

        public  Repository(string pathFile)
        {
            this.PathFile = pathFile;
            this.index = 0;
            this.workers = new Worker[7];
            this.titles= new string[] { "ID", "Дата и время создания записи", "ФИО", "Возраст", "Рост", "Дата рождения", "Место рождения" };
        }
        public void Menu()
        {
            Console.WriteLine("### Menu ###");

            Console.WriteLine("1.Просмотреть");
            Console.WriteLine("2.Записать");
            Console.WriteLine("3.Удалить запись");
            Console.WriteLine("4.Редактирование записей");
            Console.WriteLine("5.Загрузка записей по выбранным датам");
            Console.WriteLine("6.Сортировка по убыванию");
            Console.WriteLine("7.Сортировка по возрастанию");
            Console.WriteLine("\n Введите цифру команды");
            char me = char.Parse(Console.ReadLine());
            Repository per = new Repository(PathFile);

            switch (me)
            {
                case '1':
                   
                    break;
                case '2':
                    PrintW();
                    break;

            }
        }
       
        public Worker PrintW()
        {
            Worker workers = new Worker();
            Console.Write("Введите id:");
            workers.Id = Convert.ToInt32(Console.ReadLine());

            workers.DataNo = DateTime.Now;

            Console.Write("Введите ФИО");
            workers.Name = Console.ReadLine();

            Console.Write("Введите свой возраст:");
            workers.Ag = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свой рост");
            workers.Rii = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите дату рождения:");
            workers.DateBir = DateTime.Parse(Console.ReadLine());

            Console.Write("Место рождения:");
            workers.Plas = Console.ReadLine();
            return workers;

        }
        public  void Read()
        {
            using (StreamReader file = new StreamReader("dir.txt", Encoding.UTF8))
            {
                Console.WriteLine(file.ReadToEnd());
            }
        }
        public void Removal()
        {
            List<Worker> list = new List<Worker>();
            list = workers.ToList();
            Console.WriteLine("Введите id, который хотите удалить:");
            int deliteId = Convert.ToInt32(Console.ReadLine());

            foreach(Worker workers in list)
            {
                Console.WriteLine($" {workers.id}, {workers.DataNow},{workers.Name},{workers.Age},{workers.Rise},{workers.DateB},{workers.Plase}");
            }
            list.Remove(workers[deliteId]);
        }
    }
}



