namespace CapaPresentacion
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            panel1 = new Panel();
            label6 = new Label();
            lbl_Cerrar = new PictureBox();
            txt_Id = new TextBox();
            label1 = new Label();
            dtp_Desde = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtp_Hasta = new DateTimePicker();
            dvg_DetalleFactura = new DataGridView();
            btn_DescargarPdf = new Button();
            btn_DescargarExcel = new Button();
            btn_Buscar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_DetalleFactura).BeginInit();
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
            panel1.Size = new Size(672, 51);
            panel1.TabIndex = 31;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(242, 38);
            label6.TabIndex = 41;
            label6.Text = "Area de Reportes";
            // 
            // lbl_Cerrar
            // 
            lbl_Cerrar.BackColor = Color.Red;
            lbl_Cerrar.Cursor = Cursors.Hand;
            lbl_Cerrar.Image = (Image)resources.GetObject("lbl_Cerrar.Image");
            lbl_Cerrar.Location = new Point(621, 0);
            lbl_Cerrar.Name = "lbl_Cerrar";
            lbl_Cerrar.Size = new Size(48, 51);
            lbl_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_Cerrar.TabIndex = 30;
            lbl_Cerrar.TabStop = false;
            lbl_Cerrar.Click += lbl_Cerrar_Click;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(84, 105);
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(60, 27);
            txt_Id.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 74);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 38;
            label1.Text = "ID:";
            // 
            // dtp_Desde
            // 
            dtp_Desde.Format = DateTimePickerFormat.Short;
            dtp_Desde.Location = new Point(202, 105);
            dtp_Desde.Name = "dtp_Desde";
            dtp_Desde.Size = new Size(116, 27);
            dtp_Desde.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(202, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 41;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(370, 74);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 43;
            label3.Text = "Hasta:";
            // 
            // dtp_Hasta
            // 
            dtp_Hasta.Format = DateTimePickerFormat.Short;
            dtp_Hasta.Location = new Point(370, 105);
            dtp_Hasta.Name = "dtp_Hasta";
            dtp_Hasta.Size = new Size(116, 27);
            dtp_Hasta.TabIndex = 42;
            // 
            // dvg_DetalleFactura
            // 
            dvg_DetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_DetalleFactura.Location = new Point(69, 162);
            dvg_DetalleFactura.Name = "dvg_DetalleFactura";
            dvg_DetalleFactura.ReadOnly = true;
            dvg_DetalleFactura.RowHeadersWidth = 51;
            dvg_DetalleFactura.Size = new Size(555, 188);
            dvg_DetalleFactura.TabIndex = 44;
            dvg_DetalleFactura.CellContentClick += dvg_DetalleFactura_CellContentClick;
            // 
            // btn_DescargarPdf
            // 
            btn_DescargarPdf.BackColor = Color.Red;
            btn_DescargarPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DescargarPdf.Location = new Point(95, 386);
            btn_DescargarPdf.Name = "btn_DescargarPdf";
            btn_DescargarPdf.Size = new Size(211, 45);
            btn_DescargarPdf.TabIndex = 45;
            btn_DescargarPdf.Text = "Descargar Factura(PDF)";
            btn_DescargarPdf.UseVisualStyleBackColor = false;
            btn_DescargarPdf.Click += btn_DescargarPdf_Click;
            // 
            // btn_DescargarExcel
            // 
            btn_DescargarExcel.BackColor = Color.Lime;
            btn_DescargarExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DescargarExcel.ForeColor = Color.White;
            btn_DescargarExcel.Location = new Point(384, 386);
            btn_DescargarExcel.Name = "btn_DescargarExcel";
            btn_DescargarExcel.Size = new Size(211, 45);
            btn_DescargarExcel.TabIndex = 46;
            btn_DescargarExcel.Text = "Descargar Factura(Excel)";
            btn_DescargarExcel.UseVisualStyleBackColor = false;
            btn_DescargarExcel.Click += btn_DescargarExcel_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.Red;
            btn_Buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Buscar.Location = new Point(520, 102);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(104, 36);
            btn_Buscar.TabIndex = 47;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_DescargarExcel);
            Controls.Add(btn_DescargarPdf);
            Controls.Add(dvg_DetalleFactura);
            Controls.Add(label3);
            Controls.Add(dtp_Hasta);
            Controls.Add(label2);
            Controls.Add(dtp_Desde);
            Controls.Add(txt_Id);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_DetalleFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private PictureBox lbl_Cerrar;
        private TextBox txt_Id;
        private Label label1;
        private DateTimePicker dtp_Desde;
        private Label label2;
        private Label label3;
        private DateTimePicker dtp_Hasta;
        private DataGridView dvg_DetalleFactura;
        private Button btn_DescargarPdf;
        private Button btn_DescargarExcel;
        private Button btn_Buscar;
    }
}