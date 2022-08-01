using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class PastelComposite : Component
    {
        private List<Component> ingredientes = new List<Component>();

        public void Add(Component oElemento)
        { 
            ingredientes.Add(oElemento);
        }
        public void Remove(Component oElemento)
        {
            ingredientes.Remove(oElemento);
        }
        public PastelComposite(string nombre, decimal costo) : base(nombre, costo)
        {
        }
    }
}
