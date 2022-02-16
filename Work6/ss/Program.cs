using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss
{
    class Program
    {

      static List<string> list = new List<string>();

        public static void Main(string[] args)
        {
            string PathFile = "@cc.txt";
            Repository per = new Repository(PathFile);

            Console.WriteLine(File.Exists(PathFile) ? "\nСправочник уже существует. " : "\nНовый справочник создан. ");
            per.Menu();
        }
    }
}
