namespace AvaliarFilmes.App
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.Button btnCadastroAvaliacao;
        private System.Windows.Forms.Button btnCadastroFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao; // Adiciona a coluna Descrição
        private System.Windows.Forms.DataGridViewImageColumn Imagem;

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
            dgvFilmes = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            AnoLancamento = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Imagem = new DataGridViewImageColumn();
            btnCadastroAvaliacao = new Button();
            btnCadastroFilme = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmes
            // 
            dgvFilmes.AllowUserToDeleteRows = false;
            dgvFilmes.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { Titulo, AnoLancamento, Descricao, Imagem });
            dgvFilmes.Location = new Point(12, 46);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.ReadOnly = true;
            dgvFilmes.RowHeadersWidth = 51;
            dgvFilmes.RowTemplate.Height = 100;
            dgvFilmes.Size = new Size(908, 579);
            dgvFilmes.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 200;
            // 
            // AnoLancamento
            // 
            AnoLancamento.HeaderText = "Ano de Lançamento";
            AnoLancamento.MinimumWidth = 6;
            AnoLancamento.Name = "AnoLancamento";
            AnoLancamento.ReadOnly = true;
            AnoLancamento.Width = 150;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 300;
            // 
            // Imagem
            // 
            Imagem.HeaderText = "Imagem";
            Imagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagem.MinimumWidth = 6;
            Imagem.Name = "Imagem";
            Imagem.ReadOnly = true;
            Imagem.Width = 200;
            // 
            // btnCadastroAvaliacao
            // 
            btnCadastroAvaliacao.Location = new Point(12, 532);
            btnCadastroAvaliacao.Name = "btnCadastroAvaliacao";
            btnCadastroAvaliacao.Size = new Size(150, 30);
            btnCadastroAvaliacao.TabIndex = 1;
            btnCadastroAvaliacao.Text = "Cadastrar Avaliação";
            btnCadastroAvaliacao.UseVisualStyleBackColor = true;
            // 
            // btnCadastroFilme
            // 
            btnCadastroFilme.Location = new Point(180, 532);
            btnCadastroFilme.Name = "btnCadastroFilme";
            btnCadastroFilme.Size = new Size(150, 30);
            btnCadastroFilme.TabIndex = 2;
            btnCadastroFilme.Text = "Cadastrar Filme";
            btnCadastroFilme.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            BackColor = Color.Black;
            ClientSize = new Size(956, 613);
            Controls.Add(btnCadastroFilme);
            Controls.Add(btnCadastroAvaliacao);
            Controls.Add(dgvFilmes);
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Controls.SetChildIndex(dgvFilmes, 0);
            Controls.SetChildIndex(btnCadastroAvaliacao, 0);
            Controls.SetChildIndex(btnCadastroFilme, 0);
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ResumeLayout(false);
        }
    }
}