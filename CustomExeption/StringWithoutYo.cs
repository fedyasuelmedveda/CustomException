using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomExeption;

namespace CustomException
{
    internal class StringWithoutYo
    {
        public string? S { get; set; }
        public StringWithoutYo(string? s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'ё')
                    throw new YoException("Буква 'ё' запрещена!");
            }
            this.S = s;

        }
    }
}
