namespace Proyecto__Final
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Cerrar = new Guna.UI.WinForms.GunaLabel();
            this.btn_Ingresar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Usuario = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Contraseña = new Guna.UI.WinForms.GunaTextBox();
            this.moverFormulario = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Red;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Red;
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Controls.Add(this.lbl_Cerrar);
            this.gunaElipsePanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(-11, -14);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(844, 50);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(23, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(74, 31);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Login";
            // 
            // lbl_Cerrar
            // 
            this.lbl_Cerrar.AutoSize = true;
            this.lbl_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Cerrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cerrar.ForeColor = System.Drawing.Color.Black;
            this.lbl_Cerrar.Location = new System.Drawing.Point(568, 15);
            this.lbl_Cerrar.Name = "lbl_Cerrar";
            this.lbl_Cerrar.Size = new System.Drawing.Size(35, 38);
            this.lbl_Cerrar.TabIndex = 0;
            this.lbl_Cerrar.Text = "X";
            this.lbl_Cerrar.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AnimationHoverSpeed = 0.07F;
            this.btn_Ingresar.AnimationSpeed = 0.03F;
            this.btn_Ingresar.BackColor = System.Drawing.Color.Black;
            this.btn_Ingresar.BaseColor = System.Drawing.Color.Red;
            this.btn_Ingresar.BorderColor = System.Drawing.Color.Black;
            this.btn_Ingresar.CheckedBaseColor = System.Drawing.SystemColors.GrayText;
            this.btn_Ingresar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Ingresar.CheckedForeColor = System.Drawing.Color.Black;
            this.btn_Ingresar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ingresar.CheckedImage")));
            this.btn_Ingresar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.Black;
            this.btn_Ingresar.Image = global::Proyecto__Final.Properties.Resources._891372_Photoroom;
            this.btn_Ingresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Ingresar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Ingresar.Location = new System.Drawing.Point(243, 218);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Ingresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Ingresar.OnHoverForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Ingresar.OnHoverImage = null;
            this.btn_Ingresar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Ingresar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Ingresar.Size = new System.Drawing.Size(122, 42);
            this.btn_Ingresar.TabIndex = 6;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPictureBox2.Image = global::Proyecto__Final.Properties.Resources.png_transparent_computer_icons_skype_icon_design_change_password_logo_internet_share_icon_Photoroom;
            this.gunaPictureBox2.Location = new System.Drawing.Point(184, 158);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(34, 37);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 3;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BackgroundImage = global::Proyecto__Final.Properties.Resources.Captura_de_pantalla_2025_04_06_160253;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPictureBox1.Image = global::Proyecto__Final.Properties.Resources.favpng_user_login;
            this.gunaPictureBox1.Location = new System.Drawing.Point(184, 102);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(34, 37);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 2;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(217, 52);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(167, 31);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Proyecto Final";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BaseColor = System.Drawing.Color.White;
            this.txt_Usuario.BorderColor = System.Drawing.Color.Silver;
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Usuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Usuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Usuario.Location = new System.Drawing.Point(225, 107);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PasswordChar = '\0';
            this.txt_Usuario.Size = new System.Drawing.Size(160, 32);
            this.txt_Usuario.TabIndex = 11;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BaseColor = System.Drawing.Color.White;
            this.txt_Contraseña.BorderColor = System.Drawing.Color.Silver;
            this.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contraseña.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Contraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Contraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Contraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Contraseña.Location = new System.Drawing.Point(225, 163);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(160, 32);
            this.txt_Contraseña.TabIndex = 12;
            // 
            // moverFormulario
            // 
            this.moverFormulario.TargetControl = this.gunaElipsePanel1;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(591, 272);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel lbl_Cerrar;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Ingresar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_Usuario;
        private Guna.UI.WinForms.GunaTextBox txt_Contraseña;
        private Guna.UI.WinForms.GunaDragControl moverFormulario;
    }
}

