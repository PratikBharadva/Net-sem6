using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFdemo
{
    internal class student
    {
        public int studentid { get; set; }
        public string Name { get; set; }
        public int gradeid { get; set; }
        public grade Grade { get; set; }
    }
}