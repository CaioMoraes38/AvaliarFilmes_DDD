namespace AvaliarFilmes.App.Outros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnOk = new ReaLTaiizor.Controls.AirButton();
            txtRegistrar = new ReaLTaiizor.Controls.AirButton();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnCancelar = new ReaLTaiizor.Controls.AirButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnOk.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.Image = null;
            btnOk.Location = new Point(316, 314);
            btnOk.Name = "btnOk";
            btnOk.NoRounding = false;
            btnOk.Size = new Size(141, 37);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.Transparent = false;
            btnOk.Click += btnOk_Click_1;
            // 
            // txtRegistrar
            // 
            txtRegistrar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            txtRegistrar.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtRegistrar.Image = null;
            txtRegistrar.Location = new Point(72, 397);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.NoRounding = false;
            txtRegistrar.Size = new Size(385, 43);
            txtRegistrar.TabIndex = 3;
            txtRegistrar.Text = "Registrar-se";
            txtRegistrar.Transparent = false;
            txtRegistrar.Click += txtRegistrar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(72, 131);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nome";
            txtUsuario.Size = new Size(385, 39);
            txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(72, 212);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(385, 39);
            txtSenha.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnCancelar.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = null;
            btnCancelar.Location = new Point(72, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoRounding = false;
            btnCancelar.Size = new Size(141, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Transparent = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(915, 552);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtRegistrar);
            Controls.Add(btnOk);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            Controls.SetChildIndex(btnOk, 0);
            Controls.SetChildIndex(txtRegistrar, 0);
            Controls.SetChildIndex(txtUsuario, 0);
            Controls.SetChildIndex(txtSenha, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.AirButton btnOk;
        private ReaLTaiizor.Controls.AirButton txtRegistrar;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private ReaLTaiizor.Controls.AirButton btnCancelar;
        private PictureBox pictureBox1;
    }
}