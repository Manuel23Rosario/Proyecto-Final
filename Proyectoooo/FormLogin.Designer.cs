namespace Proyectoooo
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            lbl_Cerrar = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            txt_Usuario = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            txt_Contraseña = new TextBox();
            btn_Ingresar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(lbl_Cerrar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 51);
            panel1.TabIndex = 30;
            panel1.MouseDown += panel1_MouseDown_1;
            // 
            // lbl_Cerrar
            // 
            lbl_Cerrar.BackColor = Color.Red;
            lbl_Cerrar.Cursor = Cursors.Hand;
            lbl_Cerrar.Image = (Image)resources.GetObject("lbl_Cerrar.Image");
            lbl_Cerrar.Location = new Point(506, 0);
            lbl_Cerrar.Name = "lbl_Cerrar";
            lbl_Cerrar.Size = new Size(48, 51);
            lbl_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_Cerrar.TabIndex = 31;
            lbl_Cerrar.TabStop = false;
            lbl_Cerrar.Click += lbl_Cerrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(90, 38);
            label6.TabIndex = 41;
            label6.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(758, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Usuario.Location = new Point(214, 129);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "Ingrese el Usuario";
            txt_Usuario.Size = new Size(156, 30);
            txt_Usuario.TabIndex = 36;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(160, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(160, 165);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Contraseña.Location = new Point(214, 182);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PasswordChar = '*';
            txt_Contraseña.PlaceholderText = "Ingrese la Contraseña";
            txt_Contraseña.Size = new Size(180, 30);
            txt_Contraseña.TabIndex = 45;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.Red;
            btn_Ingresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ingresar.ForeColor = SystemColors.Control;
            btn_Ingresar.Location = new Point(203, 236);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(156, 35);
            btn_Ingresar.TabIndex = 46;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 67);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 42;
            label1.Text = "Proyecto Final";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(554, 292);
            Controls.Add(label1);
            Controls.Add(btn_Ingresar);
            Controls.Add(txt_Contraseña);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txt_Usuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox lbl_Cerrar;
        private TextBox txt_Usuario;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox txt_Contraseña;
        private Button btn_Ingresar;
        private Label label1;
    }
}
