using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class StudentService : IStudentService
    {
        List<StudentModel> _students;
        XMLManager manager;
       
        public StudentService()
        {
            manager = new XMLManager();
            _students = new List<StudentModel>();
        }

        public void Add(StudentModel student)
        {
            List<StudentModel> students = manager.Read();
            students.Add(student);
            manager.Insert(students); 
        }

        public void Delete(int id)
        {
            
        }

        public StudentModel Get(int id)
        {
            List<StudentModel> students = manager.Read();
            return students.FirstOrDefault(x => x._id == id);

        }

        public List<StudentModel> GetAll()
        {
            return manager.Read();
        }

        public void Update(StudentModel student)
        {
           List<StudentModel> students = manager.Read();
           StudentModel studentForUpdate = students.FirstOrDefault(x => x._id == student._id);
           studentForUpdate._age = student._age;
           studentForUpdate._name = student._name;
           manager.Update(students);
        }
    }
}
