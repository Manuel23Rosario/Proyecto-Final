namespace Proyecto__Final
{
    partial class FormFacturas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturas));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btn_GuardarFactura = new Guna.UI.WinForms.GunaButton();
            this.btn_Limpiar = new Guna.UI.WinForms.GunaButton();
            this.btn_Agrgar = new Guna.UI.WinForms.GunaButton();
            this.txt_Fecha = new Guna.UI.WinForms.GunaTextBox();
            this.cmb_Clientes = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SubTotal = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Impuesto = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Total = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Red;
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(778, 50);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 4);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(241, 38);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Area de Facturas";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(737, 1);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 45);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // btn_GuardarFactura
            // 
            this.btn_GuardarFactura.AnimationHoverSpeed = 0.07F;
            this.btn_GuardarFactura.AnimationSpeed = 0.03F;
            this.btn_GuardarFactura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_GuardarFactura.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarFactura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_GuardarFactura.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarFactura.Image")));
            this.btn_GuardarFactura.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_GuardarFactura.Location = new System.Drawing.Point(561, 342);
            this.btn_GuardarFactura.Name = "btn_GuardarFactura";
            this.btn_GuardarFactura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_GuardarFactura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_GuardarFactura.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_GuardarFactura.OnHoverImage = null;
            this.btn_GuardarFactura.OnPressedColor = System.Drawing.Color.Black;
            this.btn_GuardarFactura.Size = new System.Drawing.Size(189, 42);
            this.btn_GuardarFactura.TabIndex = 4;
            this.btn_GuardarFactura.Text = "Guardar Factura";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.AnimationHoverSpeed = 0.07F;
            this.btn_Limpiar.AnimationSpeed = 0.03F;
            this.btn_Limpiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.BorderColor = System.Drawing.Color.Black;
            this.btn_Limpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Limpiar.Location = new System.Drawing.Point(30, 400);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Limpiar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.OnHoverImage = null;
            this.btn_Limpiar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Limpiar.Size = new System.Drawing.Size(184, 42);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Quitar Producto";
            // 
            // btn_Agrgar
            // 
            this.btn_Agrgar.AnimationHoverSpeed = 0.07F;
            this.btn_Agrgar.AnimationSpeed = 0.03F;
            this.btn_Agrgar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Agrgar.BorderColor = System.Drawing.Color.Black;
            this.btn_Agrgar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Agrgar.ForeColor = System.Drawing.Color.White;
            this.btn_Agrgar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agrgar.Image")));
            this.btn_Agrgar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Agrgar.Location = new System.Drawing.Point(30, 340);
            this.btn_Agrgar.Name = "btn_Agrgar";
            this.btn_Agrgar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Agrgar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Agrgar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Agrgar.OnHoverImage = null;
            this.btn_Agrgar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Agrgar.Size = new System.Drawing.Size(184, 42);
            this.btn_Agrgar.TabIndex = 1;
            this.btn_Agrgar.Text = "Agregar Producto";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BaseColor = System.Drawing.Color.White;
            this.txt_Fecha.BorderColor = System.Drawing.Color.Silver;
            this.txt_Fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fecha.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Fecha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Fecha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Fecha.Location = new System.Drawing.Point(557, 101);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.PasswordChar = '\0';
            this.txt_Fecha.Size = new System.Drawing.Size(160, 32);
            this.txt_Fecha.TabIndex = 7;
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Clientes.BaseColor = System.Drawing.Color.White;
            this.cmb_Clientes.BorderColor = System.Drawing.Color.Silver;
            this.cmb_Clientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Clientes.ForeColor = System.Drawing.Color.Black;
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(30, 101);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb_Clientes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_Clientes.Size = new System.Drawing.Size(160, 31);
            this.cmb_Clientes.TabIndex = 9;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(30, 75);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Clientes";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(557, 75);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(47, 20);
            this.gunaLabel5.TabIndex = 13;
            this.gunaLabel5.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 139);
            this.dataGridView1.TabIndex = 15;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(29, 152);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(262, 28);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Agregar Productos/Servicios";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(293, 340);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(85, 23);
            this.gunaLabel6.TabIndex = 17;
            this.gunaLabel6.Text = "SubTotal:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(293, 381);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(97, 23);
            this.gunaLabel7.TabIndex = 18;
            this.gunaLabel7.Text = "Impuestos:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(297, 421);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(54, 23);
            this.gunaLabel8.TabIndex = 19;
            this.gunaLabel8.Text = "Total:";
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.Location = new System.Drawing.Point(385, 342);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(41, 23);
            this.lbl_SubTotal.TabIndex = 20;
            this.lbl_SubTotal.Text = "0.00";
            // 
            // lbl_Impuesto
            // 
            this.lbl_Impuesto.AutoSize = true;
            this.lbl_Impuesto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Impuesto.Location = new System.Drawing.Point(397, 383);
            this.lbl_Impuesto.Name = "lbl_Impuesto";
            this.lbl_Impuesto.Size = new System.Drawing.Size(41, 23);
            this.lbl_Impuesto.TabIndex = 21;
            this.lbl_Impuesto.Text = "0.00";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(358, 423);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(41, 23);
            this.lbl_Total.TabIndex = 22;
            this.lbl_Total.Text = "0.00";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(561, 400);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(189, 42);
            this.gunaButton1.TabIndex = 23;
            this.gunaButton1.Text = "Area De Reportes";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // FormFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Impuesto);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cmb_Clientes);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.btn_GuardarFactura);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Agrgar);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturas";
            this.Text = "FormFacturas";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaButton btn_Agrgar;
        private Guna.UI.WinForms.GunaButton btn_Limpiar;
        private Guna.UI.WinForms.GunaButton btn_GuardarFactura;
        private Guna.UI.WinForms.GunaTextBox txt_Fecha;
        private Guna.UI.WinForms.GunaComboBox cmb_Clientes;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel lbl_SubTotal;
        private Guna.UI.WinForms.GunaLabel lbl_Impuesto;
        private Guna.UI.WinForms.GunaLabel lbl_Total;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}