using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual_anonymous
{
    public class Admin
    {
        public string Numero { get; set; }
        public string Password { get; set; }
    }

    public class Student
    {
        public string Numero { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public string NumerodeTelefone { get; set; }
        public decimal nif { get; set; }
        public string Genero { get; set; }
        public string Password { get; set; }
    }

    public class Professor
    {
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
        public decimal nif { get; set; }
        public string Morada { get; set; }
        public string Genero { get; set; }
    }

}
