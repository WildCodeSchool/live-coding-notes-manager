using System;
using System.Collections.Generic;
using System.Text;

namespace NotesManager
{
    class Exam : Markable
    {
        private double _mark;
        private DateTime _dateTime;

        public Exam(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public static Exam operator +(Exam exam1, Exam exam2)
        {
            Exam examSum = new Exam(exam1.GetDateTime());
            examSum.SetMark(exam1.GetMark() + exam2.GetMark());
            return examSum;
        }

        public double GetMark()
        {
            return _mark;
        }

        public Exam SetMark(double mark)
        {
            _mark = mark;
            return this;
        }

        public DateTime GetDateTime()
        {
            return _dateTime;
        }
    }
}
