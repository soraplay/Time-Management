using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МояБиблиотека
{
    public class Common
    {
        private string name;
        private string notice;

        private const int MIN_LENGTH = 1;
        private const int MAX_LENGTH = 100;

        public Common(string name, string notice)
        {
            this.name = name;
            this.notice = notice;
        }

        public Common() { }

        public void SetName(string name)
        {
            if (name.Length < MIN_LENGTH) throw new TimeExceptions(Code.ShortName);
            if (name.Length > MAX_LENGTH) throw new TimeExceptions(Code.LongName);
            this.name = name;
        }

        public void SetNotice(string notice)
        {
            this.notice = notice;
        }

        public string GetName()
        {
            return name;
        }

        public string GetNotice()
        {
            return notice;
        }
    }
}
