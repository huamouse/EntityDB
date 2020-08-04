using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way.EntityDB
{
    public class RepeatException : Exception
    {
       
        public RepeatException(Exception inner)
            : base(inner.Message , inner)
        {
           
        }
    }
}
