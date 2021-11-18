using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    [Serializable]

    public class StudentModel
    {
        public int _id;
        public int _age;
        public string _name;
        public StudentModel()
        {

        }
        public StudentModel(int id, int age, string name)
        {
            _id = id;
            _age = age;
            _name = name;
        }

    }
}
