namespace CapaPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturas));
            panel1 = new Panel();
            label6 = new Label();
            lbl_Cerrar = new PictureBox();
            cbx_SmartTV = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Id = new TextBox();
            txt_Fecha = new TextBox();
            txt_Estado = new TextBox();
            cmb_Clientes = new ComboBox();
            cbx_Proyector = new CheckBox();
            cbx_Smartwatch = new CheckBox();
            cbx_Cámara = new CheckBox();
            cbx_Auriculares = new CheckBox();
            label7 = new Label();
            txt_Impuestos = new TextBox();
            txt_Total = new TextBox();
            label8 = new Label();
            txt_SubTotal = new TextBox();
            label9 = new Label();
            dvg_Facturas = new DataGridView();
            label10 = new Label();
            btn_GuardarFactura = new Button();
            btn_AreaReportes = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Facturas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_Cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 51);
            panel1.TabIndex = 30;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(237, 38);
            label6.TabIndex = 41;
            label6.Text = "Generar Facturas";
            // 
            // lbl_Cerrar
            // 
            lbl_Cerrar.BackColor = Color.Red;
            lbl_Cerrar.Cursor = Cursors.Hand;
            lbl_Cerrar.Image = (Image)resources.GetObject("lbl_Cerrar.Image");
            lbl_Cerrar.Location = new Point(769, 0);
            lbl_Cerrar.Name = "lbl_Cerrar";
            lbl_Cerrar.Size = new Size(48, 51);
            lbl_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_Cerrar.TabIndex = 30;
            lbl_Cerrar.TabStop = false;
            lbl_Cerrar.Click += lbl_Cerrar_Click;
            // 
            // cbx_SmartTV
            // 
            cbx_SmartTV.AutoSize = true;
            cbx_SmartTV.Location = new Point(583, 97);
            cbx_SmartTV.Name = "cbx_SmartTV";
            cbx_SmartTV.Size = new Size(146, 24);
            cbx_SmartTV.TabIndex = 31;
            cbx_SmartTV.Text = "Smart TV $15,000";
            cbx_SmartTV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 32;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 33;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(239, 66);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 34;
            label3.Text = "Clientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(389, 66);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 35;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(531, 66);
            label5.Name = "label5";
            label5.Size = new Size(257, 28);
            label5.TabIndex = 36;
            label5.Text = "Lista de Productos/Servicios";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(21, 94);
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(60, 27);
            txt_Id.TabIndex = 37;
            // 
            // txt_Fecha
            // 
            txt_Fecha.Location = new Point(106, 97);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(112, 27);
            txt_Fecha.TabIndex = 38;
            // 
            // txt_Estado
            // 
            txt_Estado.Location = new Point(389, 97);
            txt_Estado.Name = "txt_Estado";
            txt_Estado.ReadOnly = true;
            txt_Estado.Size = new Size(103, 27);
            txt_Estado.TabIndex = 39;
            txt_Estado.Text = "Pendiente";
            // 
            // cmb_Clientes
            // 
            cmb_Clientes.FormattingEnabled = true;
            cmb_Clientes.Location = new Point(239, 97);
            cmb_Clientes.Name = "cmb_Clientes";
            cmb_Clientes.Size = new Size(115, 28);
            cmb_Clientes.TabIndex = 40;
            cmb_Clientes.SelectedIndexChanged += cmb_Clientes_SelectedIndexChanged;
            // 
            // cbx_Proyector
            // 
            cbx_Proyector.AutoSize = true;
            cbx_Proyector.Location = new Point(584, 127);
            cbx_Proyector.Name = "cbx_Proyector";
            cbx_Proyector.Size = new Size(141, 24);
            cbx_Proyector.TabIndex = 41;
            cbx_Proyector.Text = "Proyector $8,000";
            cbx_Proyector.UseVisualStyleBackColor = true;
            // 
            // cbx_Smartwatch
            // 
            cbx_Smartwatch.AutoSize = true;
            cbx_Smartwatch.Location = new Point(584, 157);
            cbx_Smartwatch.Name = "cbx_Smartwatch";
            cbx_Smartwatch.Size = new Size(156, 24);
            cbx_Smartwatch.TabIndex = 42;
            cbx_Smartwatch.Text = "Smartwatch $6,500";
            cbx_Smartwatch.UseVisualStyleBackColor = true;
            // 
            // cbx_Cámara
            // 
            cbx_Cámara.AutoSize = true;
            cbx_Cámara.Location = new Point(583, 187);
            cbx_Cámara.Name = "cbx_Cámara";
            cbx_Cámara.Size = new Size(129, 24);
            cbx_Cámara.TabIndex = 43;
            cbx_Cámara.Text = "Cámara $5,300";
            cbx_Cámara.UseVisualStyleBackColor = true;
            // 
            // cbx_Auriculares
            // 
            cbx_Auriculares.AutoSize = true;
            cbx_Auriculares.Location = new Point(585, 217);
            cbx_Auriculares.Name = "cbx_Auriculares";
            cbx_Auriculares.Size = new Size(151, 24);
            cbx_Auriculares.TabIndex = 44;
            cbx_Auriculares.Text = "Auriculares $2,500";
            cbx_Auriculares.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(617, 376);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 49;
            label7.Text = "Impuestos:";
            // 
            // txt_Impuestos
            // 
            txt_Impuestos.Location = new Point(703, 373);
            txt_Impuestos.Name = "txt_Impuestos";
            txt_Impuestos.ReadOnly = true;
            txt_Impuestos.Size = new Size(97, 27);
            txt_Impuestos.TabIndex = 50;
            // 
            // txt_Total
            // 
            txt_Total.Location = new Point(703, 413);
            txt_Total.Name = "txt_Total";
            txt_Total.ReadOnly = true;
            txt_Total.Size = new Size(95, 27);
            txt_Total.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(652, 416);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 51;
            label8.Text = "Total:";
            // 
            // txt_SubTotal
            // 
            txt_SubTotal.Location = new Point(569, 413);
            txt_SubTotal.Name = "txt_SubTotal";
            txt_SubTotal.ReadOnly = true;
            txt_SubTotal.Size = new Size(84, 27);
            txt_SubTotal.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(497, 416);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 53;
            label9.Text = "SubTotal:";
            // 
            // dvg_Facturas
            // 
            dvg_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Facturas.Location = new Point(21, 187);
            dvg_Facturas.Name = "dvg_Facturas";
            dvg_Facturas.ReadOnly = true;
            dvg_Facturas.RowHeadersWidth = 51;
            dvg_Facturas.Size = new Size(532, 188);
            dvg_Facturas.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(21, 150);
            label10.Name = "label10";
            label10.Size = new Size(102, 31);
            label10.TabIndex = 56;
            label10.Text = "Facturas";
            // 
            // btn_GuardarFactura
            // 
            btn_GuardarFactura.BackColor = Color.Blue;
            btn_GuardarFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GuardarFactura.ForeColor = SystemColors.ControlLight;
            btn_GuardarFactura.Location = new Point(29, 398);
            btn_GuardarFactura.Name = "btn_GuardarFactura";
            btn_GuardarFactura.Size = new Size(162, 40);
            btn_GuardarFactura.TabIndex = 57;
            btn_GuardarFactura.Text = "Guardar Factura";
            btn_GuardarFactura.UseVisualStyleBackColor = false;
            btn_GuardarFactura.Click += btn_GuardarFactura_Click;
            // 
            // btn_AreaReportes
            // 
            btn_AreaReportes.BackColor = Color.Blue;
            btn_AreaReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AreaReportes.ForeColor = SystemColors.ControlLightLight;
            btn_AreaReportes.Location = new Point(280, 398);
            btn_AreaReportes.Name = "btn_AreaReportes";
            btn_AreaReportes.Size = new Size(162, 40);
            btn_AreaReportes.TabIndex = 58;
            btn_AreaReportes.Text = "Area de Reportes";
            btn_AreaReportes.UseVisualStyleBackColor = false;
            btn_AreaReportes.Click += btn_AreaReportes_Click;
            // 
            // FormFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(btn_AreaReportes);
            Controls.Add(btn_GuardarFactura);
            Controls.Add(label10);
            Controls.Add(dvg_Facturas);
            Controls.Add(txt_SubTotal);
            Controls.Add(label9);
            Controls.Add(txt_Total);
            Controls.Add(label8);
            Controls.Add(txt_Impuestos);
            Controls.Add(label7);
            Controls.Add(cbx_Auriculares);
            Controls.Add(cbx_Cámara);
            Controls.Add(cbx_Smartwatch);
            Controls.Add(cbx_Proyector);
            Controls.Add(cmb_Clientes);
            Controls.Add(txt_Estado);
            Controls.Add(txt_Fecha);
            Controls.Add(txt_Id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbx_SmartTV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFacturas";
            Text = "FormFacturas";
            Load += FormFacturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Facturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private PictureBox lbl_Cerrar;
        private CheckBox cbx_SmartTV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Id;
        private TextBox txt_Fecha;
        private TextBox txt_Estado;
        private ComboBox cmb_Clientes;
        private CheckBox cbx_Proyector;
        private CheckBox cbx_Smartwatch;
        private CheckBox cbx_Cámara;
        private CheckBox cbx_Auriculares;
        private Label label7;
        private TextBox txt_Impuestos;
        private TextBox txt_Total;
        private Label label8;
        private TextBox txt_SubTotal;
        private Label label9;
        private DataGridView dvg_Facturas;
        private Label label10;
        private Button btn_GuardarFactura;
        private Button btn_AreaReportes;
    }
}