namespace AvaliarFilmes.App
{
    partial class FormAvaliacoes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAvaliacoes;
        private System.Windows.Forms.Label lblTitulo;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridViewAvaliacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // dataGridViewAvaliacoes
            // 
            this.dataGridViewAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvaliacoes.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewAvaliacoes.Name = "dataGridViewAvaliacoes";
            this.dataGridViewAvaliacoes.Size = new System.Drawing.Size(760, 413);
            this.dataGridViewAvaliacoes.TabIndex = 1;
            // 
            // FormAvaliacoes
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewAvaliacoes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormAvaliacoes";
            this.Text = "Avaliações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}