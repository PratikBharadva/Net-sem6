using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFdemo
{
    internal class grade
    {
        public grade() { 
            students = new List<student>();
        }
        public int gradeid { get; set; }
        public string Gname { get; set; }
        public IList<student> students { get; set; }
    }
}
