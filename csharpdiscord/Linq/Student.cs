using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }


        public Student[] Students
        {
            get
            {
                return  new  Student[] {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                    new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
                };
            }
        }

    }

}
