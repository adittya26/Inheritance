using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
       public string _nama { get; set; }
       public int _umur { get; set; }
    
        public Person (string Nama,int Age)
        {
            _nama = Nama;
            _umur = Age;
        }
        public void getNameandAge()
        {
            Console.WriteLine();
            Console.WriteLine("Nama : {0} Age : {1} ", _nama, _umur);
        }
 
    }
}
