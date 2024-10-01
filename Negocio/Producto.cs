using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        public Producto(decimal id, string nombre, string descripcion, string descripcion2 ) { 
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Descripcion2= descripcion2;
               
        }
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
    }
}
