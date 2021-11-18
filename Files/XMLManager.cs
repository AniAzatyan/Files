using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Files
{
    public class XMLManager : IXMLManager
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<StudentModel>));
        public void Insert(List<StudentModel> students)
        {

            using (FileStream fs = new FileStream("student.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }

        public List<StudentModel> Read()
        {
            using (FileStream fs = new FileStream("student.xml", FileMode.OpenOrCreate))
            {
                List<StudentModel> students = (List<StudentModel>)formatter.Deserialize(fs);

                return students;
            }
        }

        public void Update(List<StudentModel> students)
        {
            using (FileStream fs = new FileStream("student.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }
    }
}
