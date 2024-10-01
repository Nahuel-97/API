using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Negocio
{
    public class ProductosApi
    {

        public List<Producto> GetAll()
        {
            return Datos.Productos;

        }

        public Producto GetById(int id)
        {
            var producto=Datos.Productos.FirstOrDefault(item=>item.Id==id);
            return producto;
        }

        public Producto Post(Producto producto)
        {
            Datos.Productos.Add(producto);
            return producto;
        }

        public int Delete(int id)
        {
            return Datos.Productos.RemoveAll(item=>item.Id==id);
         
        }

      

        public  Producto Put(Producto producto)
        {
            var ModProducto=Datos.Productos.FirstOrDefault(item=>item.Id==producto.Id);
            Datos.Productos.Remove(ModProducto);
            Datos.Productos.Add(producto);
            return producto;   
        }
    }
}