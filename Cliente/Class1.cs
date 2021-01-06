using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busines
{
    public class Class1
    {
        public class Clientes
        {
            public string Nome { get; set; }
            public List<Clientes> Cliente(string cliente)
            {
                var clientes = new List<Clientes>();
                clientes.Add(new Clientes() { Nome = "danilo" });
                return clientes;
            }
        }
    }
}
