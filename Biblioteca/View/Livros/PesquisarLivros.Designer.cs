
namespace Biblioteca.View.Livros
{
    partial class PesquisarLivros
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
            this.lbTituloPesquisarLivros = new System.Windows.Forms.Label();
            this.dgLivros = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbCodigoMsg = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.lbTituloPesquisarLivros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1051, 144);
            this.panel1.MinimumSize = new System.Drawing.Size(1051, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 144);
            this.panel1.TabIndex = 0;
            // 
            // lbTituloPesquisarLivros
            // 
            this.lbTituloPesquisarLivros.AutoSize = true;
            this.lbTituloPesquisarLivros.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPesquisarLivros.ForeColor = System.Drawing.Color.White;
            this.lbTituloPesquisarLivros.Location = new System.Drawing.Point(314, 44);
            this.lbTituloPesquisarLivros.Name = "lbTituloPesquisarLivros";
            this.lbTituloPesquisarLivros.Size = new System.Drawing.Size(324, 54);
            this.lbTituloPesquisarLivros.TabIndex = 4;
            this.lbTituloPesquisarLivros.Text = "Pesquisar Livros";
            this.lbTituloPesquisarLivros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgLivros
            // 
            this.dgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.titulo,
            this.autor,
            this.categoria,
            this.editora,
            this.ativo});
            this.dgLivros.Location = new System.Drawing.Point(12, 348);
            this.dgLivros.Name = "dgLivros";
            this.dgLivros.Size = new System.Drawing.Size(1011, 420);
            this.dgLivros.TabIndex = 36;
            this.dgLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLivros_CellContentClick);
            this.dgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLivros_CellContentClick);
            this.dgLivros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLivros_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código ";
            this.codigo.Name = "codigo";
            this.codigo.Width = 58;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.Width = 290;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.Width = 187;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.Width = 190;
            // 
            // editora
            // 
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            this.editora.Width = 187;
            // 
            // ativo
            // 
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.Width = 55;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(535, 283);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 41);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(387, 283);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(127, 41);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbAutor
            // 
            this.tbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAutor.Location = new System.Drawing.Point(379, 207);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(295, 26);
            this.tbAutor.TabIndex = 2;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbAutor.ForeColor = System.Drawing.Color.White;
            this.lbAutor.Location = new System.Drawing.Point(315, 207);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(58, 20);
            this.lbAutor.TabIndex = 32;
            this.lbAutor.Text = "Autor:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTitulo.Location = new System.Drawing.Point(379, 239);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(295, 26);
            this.tbTitulo.TabIndex = 3;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(315, 239);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(58, 20);
            this.lbTitulo.TabIndex = 30;
            this.lbTitulo.Text = "Título:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(303, 175);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(70, 20);
            this.lbCodigo.TabIndex = 37;
            this.lbCodigo.Text = "Código:";
            // 
            // lbCodigoMsg
            // 
            this.lbCodigoMsg.AutoSize = true;
            this.lbCodigoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoMsg.ForeColor = System.Drawing.Color.Red;
            this.lbCodigoMsg.Location = new System.Drawing.Point(680, 175);
            this.lbCodigoMsg.Name = "lbCodigoMsg";
            this.lbCodigoMsg.Size = new System.Drawing.Size(220, 20);
            this.lbCodigoMsg.TabIndex = 39;
            this.lbCodigoMsg.Text = "O Código não pode ser 0!*";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCodigo.Location = new System.Drawing.Point(379, 175);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(10);
            this.tbCodigo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(295, 26);
            this.tbCodigo.TabIndex = 1;
            // 
            // PesquisarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigoMsg);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.dgLivros);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 815);
            this.MinimumSize = new System.Drawing.Size(1051, 815);
            this.Name = "PesquisarLivros";
            this.Text = "PesquisarLivros";
            this.Load += new System.EventHandler(this.PesquisarLivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloPesquisarLivros;
        private System.Windows.Forms.DataGridView dgLivros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.Label lbCodigoMsg;
        private System.Windows.Forms.NumericUpDown tbCodigo;
    }
}