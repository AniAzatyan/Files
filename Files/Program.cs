using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            studentService.Add(new StudentModel { _name = "Anna", _id = 13, _age = 23 });
            studentService.Add(new StudentModel { _name = "Liana", _id = 15, _age = 23 });

            List<StudentModel> s = studentService.GetAll();
            studentService.Update(new StudentModel { _name = "Diana", _id = 12, _age = 20 });
        }
    }
}
