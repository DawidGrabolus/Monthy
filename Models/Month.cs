using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Monthy.Models;

internal class Month
{
    public Month(int number, string name)
    {
        Name = name;
        Number = number;    
    }
    public string Name { get; set; }
    public int Number { get; set; }

}
