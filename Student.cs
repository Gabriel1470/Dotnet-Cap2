using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_Cap2
{
    internal class Student
    {
        public string Name {get; set;}
        public int Grade  { get; set;}    
        public  ovverride string ToString()
        {
            return $"The Student {Name} Has {Grade}";
        }

   
        }
}
