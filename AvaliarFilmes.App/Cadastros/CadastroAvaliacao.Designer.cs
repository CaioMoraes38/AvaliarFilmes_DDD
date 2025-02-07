namespace AvaliarFilmes.App.Cadastros
{
    partial class CadastroAvaliacao
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

        private void InitializeComponent()
        {
            comboBoxFilmes = new ComboBox();
            labelFilme = new Label();
            labelComentario = new Label();
            txtComentario = new TextBox();
            labelNota = new Label();
            numericNota = new NumericUpDown();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericNota).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFilmes
            // 
            comboBoxFilmes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilmes.FormattingEnabled = true;
            comboBoxFilmes.Location = new Point(16, 100);
            comboBoxFilmes.Margin = new Padding(4, 5, 4, 5);
            comboBoxFilmes.Name = "comboBoxFilmes";
            comboBoxFilmes.Size = new Size(425, 28);
            comboBoxFilmes.TabIndex = 0;
            comboBoxFilmes.DoubleClick += comboBoxFilmes_DoubleClick;
            // 
            // labelFilme
            // 
            labelFilme.AutoSize = true;
            labelFilme.ForeColor = Color.White;
            labelFilme.Location = new Point(16, 75);
            labelFilme.Margin = new Padding(4, 0, 4, 0);
            labelFilme.Name = "labelFilme";
            labelFilme.Size = new Size(48, 20);
            labelFilme.TabIndex = 1;
            labelFilme.Text = "Filme:";
            // 
            // labelComentario
            // 
            labelComentario.AutoSize = true;
            labelComentario.BackColor = Color.Transparent;
            labelComentario.ForeColor = Color.White;
            labelComentario.Location = new Point(16, 133);
            labelComentario.Margin = new Padding(4, 0, 4, 0);
            labelComentario.Name = "labelComentario";
            labelComentario.Size = new Size(90, 20);
            labelComentario.TabIndex = 2;
            labelComentario.Text = "Comentário:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(16, 158);
            txtComentario.Margin = new Padding(4, 5, 4, 5);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(425, 134);
            txtComentario.TabIndex = 3;
            // 
            // labelNota
            // 
            labelNota.AutoSize = true;
            labelNota.ForeColor = Color.White;
            labelNota.Location = new Point(13, 297);
            labelNota.Margin = new Padding(4, 0, 4, 0);
            labelNota.Name = "labelNota";
            labelNota.Size = new Size(45, 20);
            labelNota.TabIndex = 4;
            labelNota.Text = "Nota:";
            // 
            // numericNota
            // 
            numericNota.Location = new Point(16, 322);
            numericNota.Margin = new Padding(4, 5, 4, 5);
            numericNota.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericNota.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericNota.Name = "numericNota";
            numericNota.Size = new Size(160, 27);
            numericNota.TabIndex = 5;
            numericNota.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(341, 314);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 35);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(464, 384);
            Controls.Add(btnSalvar);
            Controls.Add(numericNota);
            Controls.Add(labelNota);
            Controls.Add(txtComentario);
            Controls.Add(labelComentario);
            Controls.Add(labelFilme);
            Controls.Add(comboBoxFilmes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CadastroAvaliacao";
            Text = "Cadastro de Avaliação";
            Controls.SetChildIndex(comboBoxFilmes, 0);
            Controls.SetChildIndex(labelFilme, 0);
            Controls.SetChildIndex(labelComentario, 0);
            Controls.SetChildIndex(txtComentario, 0);
            Controls.SetChildIndex(labelNota, 0);
            Controls.SetChildIndex(numericNota, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            ((System.ComponentModel.ISupportInitialize)numericNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxFilmes;
        private System.Windows.Forms.Label labelFilme;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.NumericUpDown numericNota;
        private System.Windows.Forms.Button btnSalvar;
    }
}