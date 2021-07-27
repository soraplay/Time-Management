using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МояБиблиотека
{
    public enum Code
    {
        ShortName,
        LongName
    }
    class TimeExceptions : Exception
    {
        private Code code;


        public TimeExceptions(Code code)
        {
            this.code = code;
        }

        public Code GetCode()
        {
            return code;
        }
    }
}
