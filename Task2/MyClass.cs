using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MyClass
    {
        public int CountOfStudents { get; set; }
        public string NameOfSubject { get; set; }
        public string NameOfTeacher { get; set; }

        public MyClass(int count, string nameSub, string NameTeach)
        {
            NameOfSubject = nameSub;
            NameOfTeacher = NameTeach;
            CountOfStudents = count;
        }

    }
}
