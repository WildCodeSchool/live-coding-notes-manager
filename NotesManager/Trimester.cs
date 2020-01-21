using System;
using System.Collections.Generic;
using System.Text;

namespace NotesManager
{
    class Trimester : Markable
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private List<Exam> _exams;

        public Trimester(DateTime startDate, DateTime endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
        }

        public void AddExam(Exam exam)
        { }

        
        public double GetMark()
        {
            return 0.0;    // Itérer sur tous exams et faire la moyenne
        }

    }
}
