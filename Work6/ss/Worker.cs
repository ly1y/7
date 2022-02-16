using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss
{
    public struct Worker
    {
        public int id;

        public DateTime DataNow;

        public string Name;

        public int Age;
        
        public int Rise;
        
        public DateTime DateB;
        
        public string Plase;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataNo
        {
           get { return DataNow; }
            set { DataNow=value; }
        }
        public string Na
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Ag
        { 
        get { return Age; }
            set { Age = value; }
        }
        public int Rii
        { get { return Rise; }
            set { Rise = value; }
        }
        public  DateTime DateBir
        {
            get { return DateB; }
            set { DateB = value; }
        }
        public string Plas
        {
            get { return Plase; }
            set { Plase = value; }
        }

        public Worker(int Id, DateTime DataNo, string Na, int Ag, int Rii, DateTime DateBir, string Plas )
        {
            this.id = Id;
            this.DataNow = DataNo;
            this.Name = Na;
            this.Age = Ag;
            this.Rise = Rii;
            this.DateB = DateBir;
            this.Plase = Plas;
        }
        public string Print()
        {
            return $"{ this.id} {this.DataNow}{this.Name}{this.Age}{this.Rise}{this.DateB}{this.Plase} ";
        }
    }
}
