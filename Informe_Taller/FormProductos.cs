using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaInventario;
using Entidades;


namespace Informe_Taller
{
    public partial class FormProductos : Form
    {
        Producto NuevoProd;
        Producto ProdExistente;
        InvProducto invProducto = new InvProducto();
        bool nuevo = true;
        int fila;
        
        



        public FormProductos()
        {
            InitializeComponent();
            
        }

        private void LLenarDGV()
        {
            Dg_producto.Rows.Clear();

            DataSet ds = new DataSet();
            ds = invProducto.listadoProducto("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dg_producto.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString());
                }
            }

            else
                MessageBox.Show("No hay productos cargados en el sistema");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            Producto NuevoProducto;
            NuevoProducto = new Producto(int.Parse(TB_Codigo.Text), TB_Propiedades.Text);
            label4.Text= NuevoProducto.P_codigo.ToString();
            label5.Text = NuevoProducto.P_descripcion.ToString();
            Lbl_Stock.Text = "Hay " + NuevoProducto.P_stock.ToString() + "unidades";
            MessageBox.Show("Producto cargado");



            Dg_producto.Columns.Add("0", "codigo");
            Dg_producto.Columns.Add("1", "descripcion");
            Dg_producto.Columns.Add("2", "Stock");

            Dg_producto.Columns[0].Width = 100;
            Dg_producto.Columns[1].Width = 200;
            Dg_producto.Columns[2].Width = 60;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dg_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
