namespace Informe_Taller
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_CargaProduc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TB_Stock = new System.Windows.Forms.TextBox();
            this.TB_Propiedades = new System.Windows.Forms.TextBox();
            this.TB_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.TB_mov_de_productos = new System.Windows.Forms.TabPage();
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.CB_Egreso = new System.Windows.Forms.CheckBox();
            this.CB_Ingreso = new System.Windows.Forms.CheckBox();
            this.TB_Carga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dg_producto = new System.Windows.Forms.DataGridView();
            this.Lbl_Stock = new System.Windows.Forms.Label();
            this.TB_CargaProduc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TB_mov_de_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_CargaProduc
            // 
            this.TB_CargaProduc.Controls.Add(this.tabPage1);
            this.TB_CargaProduc.Controls.Add(this.TB_mov_de_productos);
            this.TB_CargaProduc.Location = new System.Drawing.Point(12, 12);
            this.TB_CargaProduc.Name = "TB_CargaProduc";
            this.TB_CargaProduc.SelectedIndex = 0;
            this.TB_CargaProduc.Size = new System.Drawing.Size(534, 256);
            this.TB_CargaProduc.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TB_Stock);
            this.tabPage1.Controls.Add(this.TB_Propiedades);
            this.tabPage1.Controls.Add(this.TB_Codigo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Btn_Cargar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga De Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TB_Stock
            // 
            this.TB_Stock.Location = new System.Drawing.Point(78, 127);
            this.TB_Stock.Name = "TB_Stock";
            this.TB_Stock.Size = new System.Drawing.Size(100, 20);
            this.TB_Stock.TabIndex = 6;
            // 
            // TB_Propiedades
            // 
            this.TB_Propiedades.Location = new System.Drawing.Point(145, 80);
            this.TB_Propiedades.Name = "TB_Propiedades";
            this.TB_Propiedades.Size = new System.Drawing.Size(164, 20);
            this.TB_Propiedades.TabIndex = 5;
            // 
            // TB_Codigo
            // 
            this.TB_Codigo.Location = new System.Drawing.Point(92, 24);
            this.TB_Codigo.Name = "TB_Codigo";
            this.TB_Codigo.Size = new System.Drawing.Size(217, 20);
            this.TB_Codigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Propiedades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Location = new System.Drawing.Point(358, 127);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cargar.TabIndex = 0;
            this.Btn_Cargar.Text = "Cargar";
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            this.Btn_Cargar.Click += new System.EventHandler(this.Btn_Cargar_Click);
            // 
            // TB_mov_de_productos
            // 
            this.TB_mov_de_productos.Controls.Add(this.Lbl_Stock);
            this.TB_mov_de_productos.Controls.Add(this.BT_Aceptar);
            this.TB_mov_de_productos.Controls.Add(this.CB_Egreso);
            this.TB_mov_de_productos.Controls.Add(this.CB_Ingreso);
            this.TB_mov_de_productos.Controls.Add(this.TB_Carga);
            this.TB_mov_de_productos.Controls.Add(this.label6);
            this.TB_mov_de_productos.Controls.Add(this.label5);
            this.TB_mov_de_productos.Controls.Add(this.label4);
            this.TB_mov_de_productos.Location = new System.Drawing.Point(4, 22);
            this.TB_mov_de_productos.Name = "TB_mov_de_productos";
            this.TB_mov_de_productos.Padding = new System.Windows.Forms.Padding(3);
            this.TB_mov_de_productos.Size = new System.Drawing.Size(526, 230);
            this.TB_mov_de_productos.TabIndex = 1;
            this.TB_mov_de_productos.Text = "Movimiento de Productos";
            this.TB_mov_de_productos.UseVisualStyleBackColor = true;
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Location = new System.Drawing.Point(384, 36);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.BT_Aceptar.Size = new System.Drawing.Size(75, 56);
            this.BT_Aceptar.TabIndex = 6;
            this.BT_Aceptar.Text = "Aceptar";
            this.BT_Aceptar.UseVisualStyleBackColor = true;
            // 
            // CB_Egreso
            // 
            this.CB_Egreso.AutoSize = true;
            this.CB_Egreso.Location = new System.Drawing.Point(269, 152);
            this.CB_Egreso.Name = "CB_Egreso";
            this.CB_Egreso.Size = new System.Drawing.Size(59, 17);
            this.CB_Egreso.TabIndex = 5;
            this.CB_Egreso.Text = "Egreso";
            this.CB_Egreso.UseVisualStyleBackColor = true;
            // 
            // CB_Ingreso
            // 
            this.CB_Ingreso.AutoSize = true;
            this.CB_Ingreso.Location = new System.Drawing.Point(269, 117);
            this.CB_Ingreso.Name = "CB_Ingreso";
            this.CB_Ingreso.Size = new System.Drawing.Size(61, 17);
            this.CB_Ingreso.TabIndex = 4;
            this.CB_Ingreso.Text = "Ingreso";
            this.CB_Ingreso.UseVisualStyleBackColor = true;
            // 
            // TB_Carga
            // 
            this.TB_Carga.Location = new System.Drawing.Point(64, 149);
            this.TB_Carga.Name = "TB_Carga";
            this.TB_Carga.Size = new System.Drawing.Size(100, 20);
            this.TB_Carga.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // Dg_producto
            // 
            this.Dg_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_producto.Location = new System.Drawing.Point(12, 270);
            this.Dg_producto.Name = "Dg_producto";
            this.Dg_producto.Size = new System.Drawing.Size(534, 168);
            this.Dg_producto.TabIndex = 1;
            this.Dg_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_producto_CellContentClick);
            // 
            // Lbl_Stock
            // 
            this.Lbl_Stock.AutoSize = true;
            this.Lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Stock.Location = new System.Drawing.Point(6, 109);
            this.Lbl_Stock.Name = "Lbl_Stock";
            this.Lbl_Stock.Size = new System.Drawing.Size(76, 25);
            this.Lbl_Stock.TabIndex = 7;
            this.Lbl_Stock.Text = "label7";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.Dg_producto);
            this.Controls.Add(this.TB_CargaProduc);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.TB_CargaProduc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TB_mov_de_productos.ResumeLayout(false);
            this.TB_mov_de_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TB_CargaProduc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TB_mov_de_productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.DataGridView Dg_producto;
        private System.Windows.Forms.TextBox TB_Stock;
        private System.Windows.Forms.TextBox TB_Propiedades;
        private System.Windows.Forms.TextBox TB_Codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Carga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.CheckBox CB_Egreso;
        private System.Windows.Forms.CheckBox CB_Ingreso;
        private System.Windows.Forms.Label Lbl_Stock;
    }
}