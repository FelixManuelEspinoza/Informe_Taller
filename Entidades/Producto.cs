using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int codigo;
        private string descripcion;
        private int stock;

        public int P_codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public String P_descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public int P_stock
        {
            get { return stock; }
        }


        public Producto (int cod, string desc )
        {
            codigo = cod;
            descripcion = desc;
            stock = 0;
        }

        public void Ingreso(int cant)
        {
            stock = stock + cant; 
        }

        public void salida(int cant)
        {
            stock = stock - cant; 
        }

    }
}
