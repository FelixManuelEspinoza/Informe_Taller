using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace Informe_Taller
{
    public partial class FormProductos : Form
    {


        public FormProductos()
        {
            InitializeComponent();
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

    }
}
