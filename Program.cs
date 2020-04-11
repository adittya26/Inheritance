using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hafiid", 19);
            person.getNameandAge();

            Teacher teacher = new Teacher("Kamar", 30, "19200", "Pemrograman");
            teacher.getNameandAge();
            teacher.getDetailTeacher();

            Student student = new Student("Pradana", 19, "2645", "pradana@gmail.com");
            student.getNameandAge();
            student.getDetailStudent();

            Console.ReadKey();
        }
    }
}
