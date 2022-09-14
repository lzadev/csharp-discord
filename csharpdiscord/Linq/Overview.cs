using System;
using System.Linq;

namespace Linq
{
    internal static class Overview
    {
        //delegate int add(int a, int b);

        delegate bool findStudent(Student student);
        public static void Do()
        {
            //Student[] std = new Student[10];
            //int i = 0;
            //foreach(var item in studentArray)
            //{
            //    if (item.Age >= 12 && item.Age <= 20)
            //    {
            //        Console.WriteLine(item);
            //        std[i] = item;
            //        i++;
            //    }
            //}

            //void DoAddtion(add add)
            //{
            //    Console.WriteLine(add(3,2));
            //}

            //DoAddtion(delegate (int num1, int num2)
            //{
            //    return num1 + num2;
            //});

            var studentArray = new Student().Students;

            //bool validateAge(findStudent student)
            //{
            //    return student();
            //}

            Func<Student, bool> validate = (student) => student.Age >= 12 && student.Age <= 20;

            //QUERY SYNTAX
            var students1 = from student in studentArray
                            where student.Age >= 12 && student.Age <= 20
                            select student;

            //METHOD SYNTAX

            var students = studentArray.Where(delegate(Student student)
            {
                return student.Age >= 12 && student.Age <= 20;
            });


            foreach (var item in students)
            {
                Console.WriteLine($"{item.StudentName}-{item.Age}");
            }
        }
    }
}
