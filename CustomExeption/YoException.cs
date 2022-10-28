using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeption
{
    internal class YoException : Exception
    {
        public YoException(string message) : base(message) { }
    }
}
