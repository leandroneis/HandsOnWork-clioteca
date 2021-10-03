
namespace Biblioteca.View.Emprestimos
{
    partial class PesquisarEmprestimo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTituloPesquisarEmprestimo = new System.Windows.Forms.Label();
            this.dgEmprestimos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lbClienteEmprestimo = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.lbTituloPesquisarEmprestimo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1051, 144);
            this.panel1.MinimumSize = new System.Drawing.Size(1051, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 144);
            this.panel1.TabIndex = 1;
            // 
            // lbTituloPesquisarEmprestimo
            // 
            this.lbTituloPesquisarEmprestimo.AutoSize = true;
            this.lbTituloPesquisarEmprestimo.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPesquisarEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lbTituloPesquisarEmprestimo.Location = new System.Drawing.Point(279, 46);
            this.lbTituloPesquisarEmprestimo.Name = "lbTituloPesquisarEmprestimo";
            this.lbTituloPesquisarEmprestimo.Size = new System.Drawing.Size(458, 54);
            this.lbTituloPesquisarEmprestimo.TabIndex = 4;
            this.lbTituloPesquisarEmprestimo.Text = "Pesquisar Empréstimos";
            this.lbTituloPesquisarEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgEmprestimos
            // 
            this.dgEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cliente,
            this.Livro,
            this.dataEmprestimo,
            this.dataDevolucao,
            this.ativo});
            this.dgEmprestimos.Location = new System.Drawing.Point(12, 333);
            this.dgEmprestimos.Name = "dgEmprestimos";
            this.dgEmprestimos.Size = new System.Drawing.Size(1011, 420);
            this.dgEmprestimos.TabIndex = 36;
            this.dgEmprestimos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            this.dgEmprestimos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            this.dgEmprestimos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código ";
            this.codigo.Name = "codigo";
            this.codigo.Width = 57;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.Width = 260;
            // 
            // Livro
            // 
            this.Livro.HeaderText = "Livro";
            this.Livro.Name = "Livro";
            this.Livro.Width = 260;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Data do Empréstimo";
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.Width = 150;
            // 
            // dataDevolucao
            // 
            this.dataDevolucao.HeaderText = "Data da Devolução";
            this.dataDevolucao.Name = "dataDevolucao";
            this.dataDevolucao.Width = 150;
            // 
            // ativo
            // 
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(551, 261);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 41);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(403, 261);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(127, 41);
            this.btnPesquisar.TabIndex = 34;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lbClienteEmprestimo
            // 
            this.lbClienteEmprestimo.AutoSize = true;
            this.lbClienteEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lbClienteEmprestimo.Location = new System.Drawing.Point(204, 187);
            this.lbClienteEmprestimo.Name = "lbClienteEmprestimo";
            this.lbClienteEmprestimo.Size = new System.Drawing.Size(141, 20);
            this.lbClienteEmprestimo.TabIndex = 30;
            this.lbClienteEmprestimo.Text = "Nome Completo:";
            // 
            // cbClientes
            // 
            this.cbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(351, 187);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(413, 28);
            this.cbClientes.TabIndex = 37;
            this.cbClientes.Text = "Selecione um Cliente";
            // 
            // PesquisarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dgEmprestimos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lbClienteEmprestimo);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 815);
            this.MinimumSize = new System.Drawing.Size(1051, 815);
            this.Name = "PesquisarEmprestimo";
            this.Text = "PesquisarEmprestimo";
            this.Load += new System.EventHandler(this.PesquisarEmprestimo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloPesquisarEmprestimo;
        private System.Windows.Forms.DataGridView dgEmprestimos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lbClienteEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.ComboBox cbClientes;
    }
}