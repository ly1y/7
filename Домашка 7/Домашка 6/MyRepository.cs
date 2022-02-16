using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Collections;


namespace Домашка_6
{
    struct MyRepository
    {

        private MyWorker[] workers; // Основной массив для хранения данных

        public string curFile; // путь к файлу с данными

        int index; // текущий элемент для добавления в workers

        string[] titles; // массив, хранящий заголовки полей. используется в PrintToConsole

        


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="CurFile">Путь в файлу с данными</param>
        public MyRepository(string CurFile)
        {
            this.curFile = CurFile; // Сохранение пути к файлу с данными
            this.index = 0; // текущая позиция для добавления сотрудника в workers
            this.workers = new MyWorker[7]; // инициализация массива сотрудников.    | изначально предпологаем, что данных нет


            this.titles = new string[] { "ID", "Дата и время создания записи", "ФИО", "Возраст", "Рост", "Дата рождения", "Место рождения" }; ;
            // инициализаия массива заголовков

        }
        /// <summary>
        /// Меню
        /// </summary>
        public void Menu()
        {
            WriteLine("\n\n[1]Вывести данные на экран  " +
                "\n[2]Заполнить данные и добавить новую запись в конец файла " +
                "\n[3]Удаление записи" +
                "\n[4]Сортировка даты min-max" +
                "\n[5]Сортировка даты max-min" +
                "\n[6]редактирование записей" +
                "\n[7]Выйти из программы ");
            int number = Convert.ToInt32(ReadLine());
            MyRepository rep = new MyRepository(curFile);

            if (number == 1)
            {
                rep.Load();
                rep.PrintToConsole();
                WriteLine($"Всего {rep.Count} сотрудников:");
                ReadKey();

                Menu();
            }

            else if (number == 2)
            {
                rep.Add(rep.PrintWorker());
                rep.Save(curFile);
                ReadKey();

                Menu();
            }

            else if (number == 3)
            {
                rep.RemoveAt();
                
                rep.Save(curFile);
                ReadKey();

                Menu();
            }

            else if (number == 4)
            {
                rep.SortMin();
                rep.Save(curFile);
                ReadKey();

                Menu();
            }

            else if (number == 5)
            {
                //rep.SortMax();
                rep.Save(curFile);
                ReadKey();

                Menu();
            }

            else if (number == 6)
            {
                //rep.Edit(workers,);
            }

            else if (number == 7)
            {
                ReadLine();
            }

            else
            {
                WriteLine("Введите верную команду");

                Menu();
            }
        }

        /// <summary>
        /// Метод увеличения текущего хранилища
        /// </summary>
        /// <param name="Flag">Условие увеличения</param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }

        /// <summary>
        /// Метод добавления сотрудника в хранилище
        /// </summary>
        /// <param name="CurWorker">Сотрудник</param>
        public void Add(MyWorker CurWorker)
        {
            this.Resize(index >= this.workers.Length);
            this.workers[index] = CurWorker;
            this.index++;
        }

        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        public void Load()
        {
            using (StreamReader staffreading = new StreamReader(this.curFile))
            {
                titles = staffreading.ReadLine().Split('#');

                while (!staffreading.EndOfStream)
                {
                    string[] workers = staffreading.ReadLine().Split('#');

                    Add(new MyWorker(Convert.ToInt32(workers[0]), DateTime.Parse(workers[1]), workers[2], Convert.ToInt32(workers[3]), Convert.ToInt32(workers[4]), workers[5], workers[6]));
                }
            }
        }

        /// <summary>
        /// Метод сохранения данных
        /// </summary>
        /// <param name="curFile">Путь к файлу сохранения</param>
        public void Save(string curFile)
        {
            if (File.Exists(curFile) == false)
            {
                string temp = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                              this.titles[0],
                                              this.titles[1],
                                              this.titles[2],
                                              this.titles[3],
                                              this.titles[4],
                                              this.titles[5],
                                              this.titles[6]);
                File.AppendAllText(curFile, $"{temp}\n");
            }

            for (int i = 0; i < this.index; i++)
            {
                string temp = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                        this.workers[i].ID,
                                        this.workers[i].Now,
                                        this.workers[i].FullName,
                                        this.workers[i].Age,
                                        this.workers[i].Height,
                                        this.workers[i].DateOfBirth,
                                        this.workers[i].PlaceOfBirth);
                File.AppendAllText(curFile, $"{temp}\n");
            }
        }

        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        public void PrintToConsole()
        {
            Console.WriteLine($"{this.titles[0],5} {this.titles[1],10} {this.titles[2],10} {this.titles[3],10} {this.titles[4],10}  {this.titles[5],15}  {this.titles[6],10} ");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
        }

        /// <summary>
        /// Количество сотрудников в хранилище
        /// </summary>
        public int Count { get { return this.index; } }

        /// <summary>
        /// Ввод пользоваателем данных
        /// </summary>
        public MyWorker PrintWorker()
        {
            MyWorker workers = new MyWorker();
            Write("\nВведите ID: ");
            workers.ID = Convert.ToInt32(ReadLine());

            WriteLine($"\nДата и время добавления записи: " + DateTime.Now);
            workers.Now = DateTime.Now;

            Write("\nВведите Ф.И.О.: ");
            workers.FullName = ReadLine();

            Write("\nВведите возраст: ");
            workers.Age = Convert.ToInt32(ReadLine());

            Write("\nВведите рост: ");
            workers.Height = Convert.ToInt32(ReadLine());

            Write("\nВведите дату рождения: ");
            workers.DateOfBirth = ReadLine();

            Write("\nВведите место рождения: ");
            workers.PlaceOfBirth = ReadLine();

            Write("\n\nЗапись создана.");

            return workers;
        }
       
        public void RemoveAt()
        {
            List<MyWorker> list = new List<MyWorker>();
            list = workers.ToList();

            WriteLine("Введите удаляемый ID: ");
            int indexClear = Convert.ToInt32(ReadLine());

            foreach (MyWorker workers in list)
            {
                WriteLine($"{workers.ID}, {workers.Now}, {workers.FullName}, {workers.Age}, {workers.Height}, {workers.DateOfBirth}, {workers.PlaceOfBirth}");
            }
            list.Remove(workers[indexClear]);

            foreach (MyWorker workers in list)
            {
                WriteLine($"{workers.ID}, {workers.Now}, {workers.FullName}, {workers.Age}, {workers.Height}, {workers.DateOfBirth}, {workers.PlaceOfBirth}");
            }


        }

            public void SortMin()
        {
            List<MyWorker> work = new List<MyWorker>();

            WriteLine("До сортировки");

            for (int i = 0; i < work.Count; i++) //не выполняется
            {
                WriteLine($"{work[i]}");
            }
            work.Sort();

            WriteLine("После сортировки");

            for (int i = 0; i < work.Count; i++) //не выполняется
            {
                WriteLine($"{work[i]}");
            }
        }

        //public void SortMax()
            
        //{
        //    this.workers = new MyWorker[7];

        //    List<MyWorker> work = new List<MyWorker>();
        //    WriteLine("До сотировки");

        //    for (int i = 0; i < workers.Length; i++)
        //    {
        //        WriteLine($"{workers[i].ID} - {workers[i].Now}");
        //    }
        //    workers = workers.OrderBy(x => x.Now).ToArray();

        //    WriteLine("После сортировки");


        //    for (int i = 0; i < workers.Length; i++)
        //    {
        //        WriteLine($"{workers[i].ID} - {workers[i].Now}");
        //    }



        //}

        public void Edit()
        {
            WriteLine("Введите ID, который хотите изменить: ");
            string E = ReadLine();

            E = E.ToLower();
            
        }
    }
}

