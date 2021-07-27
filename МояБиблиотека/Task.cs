using System;

namespace МояБиблиотека
{
    public class Task : Common
    {
        private DateTime date;
        private bool completed = false;

        public Task(string name, string notice, DateTime date) : base(name, notice)
        {
            this.date = date;
        }

        public void SetDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public bool IsCompleted()
        {
            return completed;
        }

        public override string ToString()
        {
            return $"Задача: {GetName()}, дата: {date}, выполнена {completed}, примечание: {GetNotice()}";
        }
    }
}
