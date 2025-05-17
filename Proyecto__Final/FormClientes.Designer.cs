namespace Proyecto__Final
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.moverFormulario = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.dvg_Usuarios = new System.Windows.Forms.DataGridView();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.txt_Nombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_Telefono = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_Correo = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cmb_Estado = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_VerFacturas = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Editar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Limpiar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Eliminar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Agregar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Usuarios)).BeginInit();
            this.gunaLinePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Red;
            this.gunaLinePanel1.Controls.Add(this.gunaLabel6);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(800, 48);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(755, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 46);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // moverFormulario
            // 
            this.moverFormulario.TargetControl = this.gunaLinePanel1;
            // 
            // dvg_Usuarios
            // 
            this.dvg_Usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Usuarios.GridColor = System.Drawing.SystemColors.ControlText;
            this.dvg_Usuarios.Location = new System.Drawing.Point(26, 224);
            this.dvg_Usuarios.Name = "dvg_Usuarios";
            this.dvg_Usuarios.RowHeadersWidth = 51;
            this.dvg_Usuarios.RowTemplate.Height = 24;
            this.dvg_Usuarios.Size = new System.Drawing.Size(547, 214);
            this.dvg_Usuarios.TabIndex = 1;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(600, 49);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(200, 200);
            this.gunaLinePanel2.TabIndex = 2;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.BackColor = System.Drawing.Color.Blue;
            this.gunaLinePanel3.Controls.Add(this.gunaPictureBox1);
            this.gunaLinePanel3.Controls.Add(this.btn_VerFacturas);
            this.gunaLinePanel3.Controls.Add(this.btn_Editar);
            this.gunaLinePanel3.Controls.Add(this.btn_Limpiar);
            this.gunaLinePanel3.Controls.Add(this.btn_Eliminar);
            this.gunaLinePanel3.Controls.Add(this.btn_Agregar);
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(603, 46);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(197, 406);
            this.gunaLinePanel3.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.White;
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nombre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Nombre.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Nombre.Location = new System.Drawing.Point(41, 92);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PasswordChar = '\0';
            this.txt_Nombre.Size = new System.Drawing.Size(160, 30);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.White;
            this.txt_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Telefono.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Telefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Telefono.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Telefono.Location = new System.Drawing.Point(41, 167);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.PasswordChar = '\0';
            this.txt_Telefono.Size = new System.Drawing.Size(160, 30);
            this.txt_Telefono.TabIndex = 4;
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.White;
            this.txt_Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Correo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Correo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Correo.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Correo.Location = new System.Drawing.Point(320, 91);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.PasswordChar = '\0';
            this.txt_Correo.Size = new System.Drawing.Size(160, 30);
            this.txt_Correo.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(41, 66);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 20);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Nombre:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(320, 65);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(57, 20);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Correo:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(41, 141);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(70, 20);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Telefono:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(320, 141);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(57, 20);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Estado:";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Estado.BaseColor = System.Drawing.Color.White;
            this.cmb_Estado.BorderColor = System.Drawing.Color.Silver;
            this.cmb_Estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Estado.ForeColor = System.Drawing.Color.Black;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a"});
            this.cmb_Estado.Location = new System.Drawing.Point(324, 172);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb_Estado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_Estado.Size = new System.Drawing.Size(121, 31);
            this.cmb_Estado.TabIndex = 11;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(3, 6);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(266, 38);
            this.gunaLabel6.TabIndex = 3;
            this.gunaLabel6.Text = "Gestion de clientes";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Blue;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Image = global::Proyecto__Final.Properties.Resources._12774939_Photoroom;
            this.gunaPictureBox1.Location = new System.Drawing.Point(51, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(111, 87);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btn_VerFacturas
            // 
            this.btn_VerFacturas.AnimationHoverSpeed = 0.07F;
            this.btn_VerFacturas.AnimationSpeed = 0.03F;
            this.btn_VerFacturas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_VerFacturas.BorderColor = System.Drawing.Color.Black;
            this.btn_VerFacturas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_VerFacturas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_VerFacturas.CheckedForeColor = System.Drawing.Color.White;
            this.btn_VerFacturas.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_VerFacturas.CheckedImage")));
            this.btn_VerFacturas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_VerFacturas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerFacturas.ForeColor = System.Drawing.Color.Black;
            this.btn_VerFacturas.Image = global::Proyecto__Final.Properties.Resources.png_clipart_bank_business_invoice_computer_icons_computer_software_bank_text_service_Photoroom;
            this.btn_VerFacturas.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_VerFacturas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_VerFacturas.Location = new System.Drawing.Point(35, 339);
            this.btn_VerFacturas.Name = "btn_VerFacturas";
            this.btn_VerFacturas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_VerFacturas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_VerFacturas.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_VerFacturas.OnHoverImage = null;
            this.btn_VerFacturas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_VerFacturas.OnPressedColor = System.Drawing.Color.Black;
            this.btn_VerFacturas.Size = new System.Drawing.Size(150, 42);
            this.btn_VerFacturas.TabIndex = 4;
            this.btn_VerFacturas.Text = "Ver Facturas";
            this.btn_VerFacturas.Click += new System.EventHandler(this.btn_VerFacturas_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.AnimationHoverSpeed = 0.07F;
            this.btn_Editar.AnimationSpeed = 0.03F;
            this.btn_Editar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Editar.BorderColor = System.Drawing.Color.Black;
            this.btn_Editar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Editar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Editar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Editar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Editar.CheckedImage")));
            this.btn_Editar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Image = global::Proyecto__Final.Properties.Resources.png_transparent_edit_edit_doc_draw_editting_pen_and_paper_tool_write_project_management_icon_thumbnail_Photoroom;
            this.btn_Editar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Editar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Editar.Location = new System.Drawing.Point(35, 237);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Editar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Editar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Editar.OnHoverImage = null;
            this.btn_Editar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Editar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Editar.Size = new System.Drawing.Size(140, 42);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.AnimationHoverSpeed = 0.07F;
            this.btn_Limpiar.AnimationSpeed = 0.03F;
            this.btn_Limpiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Limpiar.BorderColor = System.Drawing.Color.Black;
            this.btn_Limpiar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Limpiar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Limpiar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.CheckedImage")));
            this.btn_Limpiar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Limpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_Limpiar.Image = global::Proyecto__Final.Properties.Resources.png_transparent_cleaning_cleaner_maid_service_computer_icons_others_angle_bathroom_monochrome_Photoroom;
            this.btn_Limpiar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Limpiar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Limpiar.Location = new System.Drawing.Point(35, 189);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Limpiar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.OnHoverImage = null;
            this.btn_Limpiar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Limpiar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Limpiar.Size = new System.Drawing.Size(140, 42);
            this.btn_Limpiar.TabIndex = 2;
            this.btn_Limpiar.Text = "Limpiar";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.AnimationHoverSpeed = 0.07F;
            this.btn_Eliminar.AnimationSpeed = 0.03F;
            this.btn_Eliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.BorderColor = System.Drawing.Color.Black;
            this.btn_Eliminar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Eliminar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.CheckedImage")));
            this.btn_Eliminar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Image = global::Proyecto__Final.Properties.Resources.delete_icon_or_logo_illustration_outline_black_style_free_vector_Photoroom;
            this.btn_Eliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Eliminar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(35, 141);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Eliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Eliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.OnHoverImage = null;
            this.btn_Eliminar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Eliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Size = new System.Drawing.Size(140, 42);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.Text = "Eliminar";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.AnimationHoverSpeed = 0.07F;
            this.btn_Agregar.AnimationSpeed = 0.03F;
            this.btn_Agregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Agregar.BorderColor = System.Drawing.Color.Black;
            this.btn_Agregar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Agregar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Agregar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Agregar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.CheckedImage")));
            this.btn_Agregar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Image = global::Proyecto__Final.Properties.Resources.png_transparent_computer_icons_add_logo_desktop_wallpaper_add_thumbnail_Photoroom;
            this.btn_Agregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Agregar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Agregar.Location = new System.Drawing.Point(35, 93);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Agregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Agregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Agregar.OnHoverImage = null;
            this.btn_Agregar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Agregar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Agregar.Size = new System.Drawing.Size(140, 42);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.gunaLinePanel3);
            this.Controls.Add(this.dvg_Usuarios);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Usuarios)).EndInit();
            this.gunaLinePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDragControl moverFormulario;
        private System.Windows.Forms.DataGridView dvg_Usuarios;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_VerFacturas;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Editar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Limpiar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Eliminar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Agregar;
        private Guna.UI.WinForms.GunaLineTextBox txt_Nombre;
        private Guna.UI.WinForms.GunaLineTextBox txt_Telefono;
        private Guna.UI.WinForms.GunaLineTextBox txt_Correo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox cmb_Estado;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}