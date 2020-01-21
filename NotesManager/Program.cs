using System;
using System.Collections.Generic;

namespace NotesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Test", 35);
            List<Student> students = new List<Student>();

            for (int i = 0; i < 3; i++)
            {
                teacher.ProduceExam(DateTime.Today);
                Student newStudent = new Student("Richard", 17);
                students.Add(newStudent);
            }

            List<Exam> exams = teacher.GetProducedExams();

            foreach (Student studentToExam in students)
            {
                foreach (Exam examToPass in exams)
                {
                    studentToExam.PassExam(examToPass);
                }
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.GetName() + ": " + student.GetMean(DateTime.Today, DateTime.Today));
            }
        }
    }
}
