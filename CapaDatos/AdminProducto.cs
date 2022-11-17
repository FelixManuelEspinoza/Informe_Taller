using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class AdminProducto : DatosConexion
    {
        public int abmProducto(string accion, Producto ObjProducto)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Producto values (" + ObjProducto.P_codigo +
                    ",'" + ObjProducto.P_descripcion + "' , "+ObjProducto.P_stock + ");''";
            
            if (accion == "Modificar")
                orden = "update Producto set Descripion='" + ObjProducto.P_descripcion + "', Stock=" +
               ObjProducto.P_stock + "Where Codigo=" + ObjProducto.P_codigo + "; ";
              // falta la orden de borrar
            
            SqlConnection cmd = new SqlConnection(orden );
            try
            {
                Abrirconexion();
                //resultado = cmd. ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar de Producto",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoProductos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Producto where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Productos;";
            SqlConnection cmd = new SqlConnection(orden, Connection);
            DataSet ds = new DataSet();
            SqlConnection da = new SqlConnection();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar producto", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
    

