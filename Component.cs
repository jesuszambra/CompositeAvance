using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        public  string Nombre { get; set; }
        public decimal Costo { get; set; }

        public Component( string nombre, decimal costo) 
        {
        this.Nombre = nombre;
            this.Costo = costo;
        }
    }
}
