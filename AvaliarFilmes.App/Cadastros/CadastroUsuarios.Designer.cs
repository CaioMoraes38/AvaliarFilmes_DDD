namespace AvaliarFilmes.App.Cadastros
{
    partial class CadastroUsuarios
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            pictureBoxFoto = new PictureBox();
            btnSalvar = new ReaLTaiizor.Controls.AirButton();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            btnCarregaFoto = new ReaLTaiizor.Controls.AirButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(39, 298);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(488, 39);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(39, 379);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(488, 39);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(39, 456);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(488, 39);
            txtSenha.TabIndex = 7;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.BackColor = Color.White;
            pictureBoxFoto.Location = new Point(741, 298);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(278, 221);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFoto.TabIndex = 8;
            pictureBoxFoto.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnSalvar.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Image = null;
            btnSalvar.Location = new Point(386, 538);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoRounding = false;
            btnSalvar.Size = new Size(141, 37);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.Transparent = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // airButton1
            // 
            airButton1.BackColor = Color.White;
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            airButton1.Image = null;
            airButton1.Location = new Point(39, 538);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(141, 37);
            airButton1.TabIndex = 10;
            airButton1.Text = "Cancelar";
            airButton1.Transparent = false;
            airButton1.Click += airButton1_Click;
            // 
            // btnCarregaFoto
            // 
            btnCarregaFoto.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnCarregaFoto.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarregaFoto.Image = null;
            btnCarregaFoto.Location = new Point(741, 538);
            btnCarregaFoto.Name = "btnCarregaFoto";
            btnCarregaFoto.NoRounding = false;
            btnCarregaFoto.Size = new Size(278, 37);
            btnCarregaFoto.TabIndex = 11;
            btnCarregaFoto.Text = "Importar";
            btnCarregaFoto.Transparent = false;
            btnCarregaFoto.Click += btnCarregaFoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.panda;
            pictureBox1.Location = new Point(296, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // CadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1167, 688);
            Controls.Add(pictureBox1);
            Controls.Add(btnCarregaFoto);
            Controls.Add(airButton1);
            Controls.Add(btnSalvar);
            Controls.Add(pictureBoxFoto);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            MaximizeBox = false;
            Name = "CadastroUsuarios";
            Text = "CadastroUsuarios";
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(txtSenha, 0);
            Controls.SetChildIndex(pictureBoxFoto, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(airButton1, 0);
            Controls.SetChildIndex(btnCarregaFoto, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private PictureBox pictureBoxFoto;
        private ReaLTaiizor.Controls.AirButton btnSalvar;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.AirButton btnCarregaFoto;
        private PictureBox pictureBox1;
    }
}