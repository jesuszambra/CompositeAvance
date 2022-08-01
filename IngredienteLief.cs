using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class IngredienteLief : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
        public IngredienteLief(string nombre, decimal costo, int Cantidad, string Unidad) : base(nombre, costo)
        {
            this.Cantidad = Cantidad;

            this.Unidad = Unidad;
        }
    }
}
