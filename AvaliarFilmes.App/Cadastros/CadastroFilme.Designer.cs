namespace AvaliarFilmes.App.Cadastros
{
    partial class CadastroFilme
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            txtDescricao = new TextBox();
            txtAnoLancamento = new TextBox();
            txtDuracao = new TextBox();
            comboBoxCategorias = new ComboBox();
            pictureBoxImagemFilme = new PictureBox();
            btnSalvar = new Button();
            btnCarregaImagem = new Button();
            labelNota = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            btnAddCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemFilme).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(30, 262);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(293, 27);
            txtTitulo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(30, 121);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(293, 115);
            txtDescricao.TabIndex = 1;
            // 
            // txtAnoLancamento
            // 
            txtAnoLancamento.Location = new Point(30, 318);
            txtAnoLancamento.Name = "txtAnoLancamento";
            txtAnoLancamento.Size = new Size(293, 27);
            txtAnoLancamento.TabIndex = 2;
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(30, 374);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(293, 27);
            txtDuracao.TabIndex = 3;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(30, 427);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(293, 28);
            comboBoxCategorias.TabIndex = 4;
            // 
            // pictureBoxImagemFilme
            // 
            pictureBoxImagemFilme.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImagemFilme.Location = new Point(391, 121);
            pictureBoxImagemFilme.Name = "pictureBoxImagemFilme";
            pictureBoxImagemFilme.Size = new Size(237, 191);
            pictureBoxImagemFilme.TabIndex = 5;
            pictureBoxImagemFilme.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(519, 422);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 36);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCarregaImagem
            // 
            btnCarregaImagem.Location = new Point(391, 318);
            btnCarregaImagem.Name = "btnCarregaImagem";
            btnCarregaImagem.Size = new Size(237, 36);
            btnCarregaImagem.TabIndex = 7;
            btnCarregaImagem.Text = "Carregar Imagem";
            btnCarregaImagem.UseVisualStyleBackColor = true;
            btnCarregaImagem.Click += btnCarregaImagem_Click;
            // 
            // labelNota
            // 
            labelNota.AutoSize = true;
            labelNota.ForeColor = Color.White;
            labelNota.Location = new Point(30, 404);
            labelNota.Margin = new Padding(4, 0, 4, 0);
            labelNota.Name = "labelNota";
            labelNota.Size = new Size(74, 20);
            labelNota.TabIndex = 8;
            labelNota.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 295);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 351);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 10;
            label2.Text = "Duração( Minutos)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 295);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 11;
            label3.Text = "Ano de Lançamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 239);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 12;
            label4.Text = "Titulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 98);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 13;
            label5.Text = "Sinopse";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(391, 422);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 36);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.Location = new Point(30, 461);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(182, 36);
            btnAddCategoria.TabIndex = 15;
            btnAddCategoria.Text = "Adiciona Categoria";
            btnAddCategoria.UseVisualStyleBackColor = true;
            btnAddCategoria.Click += btnAddCategoria_Click;
            // 
            // CadastroFilme
            // 
            BackColor = Color.Black;
            ClientSize = new Size(663, 521);
            Controls.Add(btnAddCategoria);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelNota);
            Controls.Add(txtTitulo);
            Controls.Add(txtDescricao);
            Controls.Add(txtAnoLancamento);
            Controls.Add(txtDuracao);
            Controls.Add(comboBoxCategorias);
            Controls.Add(pictureBoxImagemFilme);
            Controls.Add(btnSalvar);
            Controls.Add(btnCarregaImagem);
            Name = "CadastroFilme";
            Text = "Cadastro de Filme";
            Controls.SetChildIndex(btnCarregaImagem, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(pictureBoxImagemFilme, 0);
            Controls.SetChildIndex(comboBoxCategorias, 0);
            Controls.SetChildIndex(txtDuracao, 0);
            Controls.SetChildIndex(txtAnoLancamento, 0);
            Controls.SetChildIndex(txtDescricao, 0);
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(labelNota, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnAddCategoria, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemFilme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtAnoLancamento;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.PictureBox pictureBoxImagemFilme;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregaImagem;
        private Label labelNota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCancelar;
        private Button btnAddCategoria;
    }
}