using System;
using System.Collections.Generic;
using System.Linq;

namespace NotesManager
{
    class Student : AbstractPerson
    {
        private List<Exam> _exams;

        public Student(string name, int age) : base(name, age)
        {
            _exams = new List<Exam>();
        }

        public void PassExam(Exam exam)
        {
            exam.SetMark(10);
            _exams.Add(exam);
        }

        /*
        public double GetMarkFromExam(Exam exam)
        { 
            //
        }

        public double GetSum(DateTime startDate, DateTime endDate)
        { }
        */
        
        public double GetMean(DateTime startDate, DateTime endDate)
        {
            List<Exam> examsBetweenDates = _exams.Where(exam => exam.GetDateTime() >= startDate && 
                                                                endDate >= exam.GetDateTime()).ToList();
            Exam sumExam = _exams.Aggregate((x, y) => x + y);
            return sumExam.GetMark() / _exams.Count;
        }
    }
}
