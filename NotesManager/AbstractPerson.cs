using System;
using System.Collections.Generic;
using System.Text;

namespace NotesManager
{
    abstract class AbstractPerson
    {
        protected string _name;
        protected int _age;
        protected bool _isOnHolidays;

        public AbstractPerson(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName()
        {
            return _name;
        }

        public void GoHolidays()
        {
            _isOnHolidays = true;
        }

        public void ComeHome()
        {
            _isOnHolidays = false;
        }
    }
}
