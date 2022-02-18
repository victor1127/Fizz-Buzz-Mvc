using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Models
{
    public class FizzBuzzModel
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public List<string> FizzBuzz { get; set; } = new();

    }
}
