using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Person
    {
        public string _IdTeacher { get; set; }
        public string _Subject { get; set; }

        public Teacher (string Nama, int Age, string Id , string sub) : base (Nama,Age)
        {
            _nama = Nama;
            _umur = Age;
            _IdTeacher = Id;
            _Subject = sub;
            
        }

        public void getDetailTeacher()
        {
            
            Console.WriteLine("id : {0} matkul : {1}", _IdTeacher, _Subject);
        }
    }
}
