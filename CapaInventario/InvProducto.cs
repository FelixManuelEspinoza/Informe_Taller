using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;

namespace CapaInventario
{
    public class InvProducto
    {
        AdminProducto ObjDatProducto = new AdminProducto();

        public int abmProducto (string accion, Producto objProducto)
        {
            return ObjDatProducto. abmProducto (accion, objProducto);
        }
        public DataSet listadoProducto(string cual)
        {
            return ObjDatProducto.listadoProductos(cual);
        }
    }
}
