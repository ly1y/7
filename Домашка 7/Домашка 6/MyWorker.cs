using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Домашка_6
{
    /// <summary>
    /// Справочник Сотрудники
    /// </summary>
    public struct MyWorker
    {
        #region Поля. (Описывают сотрудника)

        /// <summary>
        /// ID
        /// </summary>
        /// <param name="ID"></param>
        public int id;

        /// <summary>
        /// Время и дата создания записи 
        /// </summary>
        public DateTime now;

        /// <summary>
        /// ФИО 
        /// </summary>
        public string fullName;

        /// <summary>
        /// Возраст сотрудника 
        /// </summary>
        public int age;

        /// <summary>
        /// рост сотрудника
        /// </summary>
        public int height;

        /// <summary>
        /// Дата рождения сотрудника 
        /// </summary>
        public string dateOfBirth;

        /// <summary>
        /// Место рождения сотрудника;
        /// </summary>
        public string placeOfBirth;

        #endregion

        #region Свойства
        /// <summary>
        /// ID (Чтение и изменение)
        /// </summary>
        /// <param name="ID"></param>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Время и дата создания записи (Чтение)
        /// </summary>
        public DateTime Now
        {
            get { return now; }
            set { now = value; }
        }
       
        /// <summary>
        /// ФИО (Чтение и изменение)
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        /// <summary>
        /// Возраст сотрудника (Чтение и изменение)
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// рост сотрудника (Чтение и изменение)
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// Дата рождения сотрудника (Чтение и изменение)
        /// </summary>
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        /// <summary>
        /// Место рождения сотрудника (Чтение и изменение)
        /// </summary>
        public string PlaceOfBirth
        {
            get { return placeOfBirth; }
            set { placeOfBirth = value; }
        }

        #endregion

        #region Создание сотрудника

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="Now">Дата и время создания записи</param>
        /// <param name="FullName">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateOfBirth">Дата рождеия</param>
        /// <param name="PlaceOfBirth">Место рождения</param>
        public MyWorker(int ID, DateTime Now, string FullName, int Age, int Height, string DateOfBirth, string PlaceOfBirth)
        {
            this.id = ID;
            this.now = Now;
            this.fullName = FullName;
            this.age = Age;
            this.height = Height;
            this.dateOfBirth = DateOfBirth;
            this.placeOfBirth = PlaceOfBirth;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Вывод на экран данных о сотруднике
        /// </summary>
        public string Print()
        {
            return $"{this.id, 5} {this.now,10} {this.fullName,10} {this.age,10} {this.height,10} {this.dateOfBirth,15} {this.placeOfBirth,10}";
        }

        #endregion
    }
}
