using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    internal class DatosConexion
    {
        public OleDbConnection Connection;
        public string CadenaConexion = @"Data Source=DESKTOP-417K253;Initial Catalog=ProductosMec;Integrated Security=True";
        
        public DatosConexion()
        {
            Connection = new OleDbConnection(CadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (Connection.State == ConnectionState.Broken || Connection.State ==
                ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }


        }

        public void Cerrarconexion()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}

