using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class SysCall
    {
        public int ID;
        public string Name;
        public List<Arg> Args;
        public SysCall(int id, string name, List<Arg> args) {
            ID = id;
            Name = name;
            Args = args;
        }
    }
    
}
