using System;
using System.Collections.Generic;
using System.Text;

namespace NotesManager
{
    class Teacher : AbstractPerson
    {
        private List<Exam> _producedExams;

        public Teacher(string name, int age) : base(name, age)
        {
            _producedExams = new List<Exam>();
        }

        public Exam ProduceExam(DateTime dateTime)
        {
            Exam exam = new Exam(dateTime);
            _producedExams.Add(exam);
            return exam;
        }

        public List<Exam> GetProducedExams()
        {
            return _producedExams;
        }
    }
}
