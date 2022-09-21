using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Arg
    {
        public string Name;
        public string Type;
        public int Value;
        public Arg(string name, string type, int value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
        public Arg(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
