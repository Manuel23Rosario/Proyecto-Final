namespace Proyectoooo
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            dvg_Usuarios = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            lbl_Cerrar = new PictureBox();
            panel2 = new Panel();
            btn_VerFactura = new Button();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            btn_Limpiar = new Button();
            btn_Agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Id = new TextBox();
            txt_Nombre = new TextBox();
            txt_Correo = new TextBox();
            label4 = new Label();
            txt_Telefono = new TextBox();
            label5 = new Label();
            cmb_Estado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dvg_Usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvg_Usuarios
            // 
            dvg_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Usuarios.Location = new Point(26, 247);
            dvg_Usuarios.Name = "dvg_Usuarios";
            dvg_Usuarios.ReadOnly = true;
            dvg_Usuarios.RowHeadersWidth = 51;
            dvg_Usuarios.Size = new Size(574, 204);
            dvg_Usuarios.TabIndex = 18;
            dvg_Usuarios.CellClick += dvg_Usuarios_CellClick;
            dvg_Usuarios.CellContentClick += dvg_Usuarios_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_Cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 51);
            panel1.TabIndex = 29;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(256, 38);
            label6.TabIndex = 41;
            label6.Text = "Gestion de Cliente";
            // 
            // lbl_Cerrar
            // 
            lbl_Cerrar.BackColor = Color.Red;
            lbl_Cerrar.Cursor = Cursors.Hand;
            lbl_Cerrar.Image = (Image)resources.GetObject("lbl_Cerrar.Image");
            lbl_Cerrar.Location = new Point(758, 0);
            lbl_Cerrar.Name = "lbl_Cerrar";
            lbl_Cerrar.Size = new Size(48, 51);
            lbl_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_Cerrar.TabIndex = 30;
            lbl_Cerrar.TabStop = false;
            lbl_Cerrar.Click += lbl_Cerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(btn_VerFactura);
            panel2.Controls.Add(btn_Editar);
            panel2.Controls.Add(btn_Eliminar);
            panel2.Controls.Add(btn_Limpiar);
            panel2.Controls.Add(btn_Agregar);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(626, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 414);
            panel2.TabIndex = 30;
            // 
            // btn_VerFactura
            // 
            btn_VerFactura.BackColor = Color.Red;
            btn_VerFactura.ForeColor = SystemColors.Control;
            btn_VerFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btn_VerFactura.Location = new Point(27, 366);
            btn_VerFactura.Name = "btn_VerFactura";
            btn_VerFactura.Size = new Size(132, 35);
            btn_VerFactura.TabIndex = 35;
            btn_VerFactura.Text = "Ver Facturas";
            btn_VerFactura.UseVisualStyleBackColor = false;
            btn_VerFactura.Click += btn_VerFactura_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.BackColor = Color.Red;
            btn_Editar.ForeColor = SystemColors.Control;
            btn_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Editar.Location = new Point(38, 232);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(110, 35);
            btn_Editar.TabIndex = 34;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = false;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.Red;
            btn_Eliminar.ForeColor = SystemColors.Control;
            btn_Eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Eliminar.Location = new Point(38, 147);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(110, 35);
            btn_Eliminar.TabIndex = 33;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.Red;
            btn_Limpiar.ForeColor = SystemColors.Control;
            btn_Limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Limpiar.Location = new Point(38, 191);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(110, 35);
            btn_Limpiar.TabIndex = 32;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.Red;
            btn_Agregar.ForeColor = SystemColors.Control;
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(37, 106);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(111, 35);
            btn_Agregar.TabIndex = 31;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 66);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 31;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 66);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 32;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(360, 66);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 33;
            label3.Text = "Correo:";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(43, 97);
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(57, 27);
            txt_Id.TabIndex = 34;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(170, 97);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Nombre del cliente";
            txt_Nombre.Size = new Size(136, 27);
            txt_Nombre.TabIndex = 35;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(360, 97);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.PlaceholderText = "Correo del cliente";
            txt_Correo.Size = new Size(163, 27);
            txt_Correo.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 144);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 37;
            label4.Text = "Telefono:";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(84, 175);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.PlaceholderText = "Telefono del cliente";
            txt_Telefono.Size = new Size(163, 27);
            txt_Telefono.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(320, 144);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 39;
            label5.Text = "Estado:";
            // 
            // cmb_Estado
            // 
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Items.AddRange(new object[] { "Soltero/a", "Casado/a", "Viudo/a" });
            cmb_Estado.Location = new Point(320, 175);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(116, 28);
            cmb_Estado.TabIndex = 40;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 463);
            Controls.Add(cmb_Estado);
            Controls.Add(label5);
            Controls.Add(txt_Telefono);
            Controls.Add(label4);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dvg_Usuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_Usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvg_Usuarios;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox lbl_Cerrar;
        private Panel panel2;
        private Button btn_Agregar;
        private Button btn_VerFactura;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Button btn_Limpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txt_Id;
        private TextBox txt_Nombre;
        private TextBox txt_Correo;
        private Label label4;
        private TextBox txt_Telefono;
        private Label label5;
        private ComboBox cmb_Estado;
    }
}