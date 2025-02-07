namespace AvaliarFilmes.App.Cadastros
{
    partial class CadastroCategoria
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNomeCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Button btnSalvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNomeCategoria = new Label();
            txtNomeCategoria = new TextBox();
            btnSalvar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.BackColor = Color.Transparent;
            lblNomeCategoria.ForeColor = Color.White;
            lblNomeCategoria.Location = new Point(12, 51);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(143, 20);
            lblNomeCategoria.TabIndex = 0;
            lblNomeCategoria.Text = "Nome da Categoria:";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(12, 85);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(237, 27);
            txtNomeCategoria.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(174, 143);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 33);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroCategoria
            // 
            BackColor = Color.Black;
            ClientSize = new Size(288, 250);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCategoria);
            Controls.Add(lblNomeCategoria);
            Name = "CadastroCategoria";
            Text = "Cadastro de Categoria";
            Controls.SetChildIndex(lblNomeCategoria, 0);
            Controls.SetChildIndex(txtNomeCategoria, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(button1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}