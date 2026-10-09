using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual_anonymous
{
    internal class SchoolYear
    {
        public string Year { get; set; }

        public List<Classes> Classes { get; set; } = new List<Classes>();
    }
}
