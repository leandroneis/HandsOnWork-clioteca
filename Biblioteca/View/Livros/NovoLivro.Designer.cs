
namespace Biblioteca.View.Livros
{
    partial class NovoLivro
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
            this.lbTituloNovoLivro = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbCep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.lbEditora = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lbAutorLivro = new System.Windows.Forms.Label();
            this.tbTituloLivro = new System.Windows.Forms.TextBox();
            this.lbTituloLivro = new System.Windows.Forms.Label();
            this.lbTituloObrigatorio = new System.Windows.Forms.Label();
            this.lbEditoraObrigatorio = new System.Windows.Forms.Label();
            this.lbCategoriaObrigatorio = new System.Windows.Forms.Label();
            this.lbAutorObrigatorio = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbNumeroDePaginas = new System.Windows.Forms.NumericUpDown();
            this.lbEstoqueObrigatorio = new System.Windows.Forms.Label();
            this.lbEstoque = new System.Windows.Forms.Label();
            this.tbEstoque = new System.Windows.Forms.NumericUpDown();
            this.tbQuantidadeLivrosReservados = new System.Windows.Forms.NumericUpDown();
            this.lbQuantidadeLivrosReservados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDePaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantidadeLivrosReservados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.lbTituloNovoLivro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1051, 144);
            this.panel1.MinimumSize = new System.Drawing.Size(1051, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 144);
            this.panel1.TabIndex = 2;
            // 
            // lbTituloNovoLivro
            // 
            this.lbTituloNovoLivro.AutoSize = true;
            this.lbTituloNovoLivro.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloNovoLivro.ForeColor = System.Drawing.Color.White;
            this.lbTituloNovoLivro.Location = new System.Drawing.Point(344, 45);
            this.lbTituloNovoLivro.Name = "lbTituloNovoLivro";
            this.lbTituloNovoLivro.Size = new System.Drawing.Size(228, 54);
            this.lbTituloNovoLivro.TabIndex = 4;
            this.lbTituloNovoLivro.Text = "Novo Livro";
            this.lbTituloNovoLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(474, 627);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 41);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(361, 627);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 41);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.ForeColor = System.Drawing.Color.White;
            this.lbCep.Location = new System.Drawing.Point(240, 457);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(46, 20);
            this.lbCep.TabIndex = 65;
            this.lbCep.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(545, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "N° de Pág:";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCategoria.ForeColor = System.Drawing.Color.Black;
            this.tbCategoria.Location = new System.Drawing.Point(543, 344);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(291, 26);
            this.tbCategoria.TabIndex = 4;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCategoria.Location = new System.Drawing.Point(543, 312);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(99, 20);
            this.lbCategoria.TabIndex = 59;
            this.lbCategoria.Text = "Categoria:*";
            // 
            // tbEditora
            // 
            this.tbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEditora.ForeColor = System.Drawing.Color.Black;
            this.tbEditora.Location = new System.Drawing.Point(243, 418);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(292, 26);
            this.tbEditora.TabIndex = 5;
            // 
            // lbEditora
            // 
            this.lbEditora.AutoSize = true;
            this.lbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbEditora.ForeColor = System.Drawing.Color.White;
            this.lbEditora.Location = new System.Drawing.Point(239, 386);
            this.lbEditora.Name = "lbEditora";
            this.lbEditora.Size = new System.Drawing.Size(79, 20);
            this.lbEditora.TabIndex = 55;
            this.lbEditora.Text = "Editora:*";
            // 
            // tbAutor
            // 
            this.tbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAutor.ForeColor = System.Drawing.Color.Black;
            this.tbAutor.Location = new System.Drawing.Point(244, 344);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(291, 26);
            this.tbAutor.TabIndex = 3;
            // 
            // lbAutorLivro
            // 
            this.lbAutorLivro.AutoSize = true;
            this.lbAutorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbAutorLivro.ForeColor = System.Drawing.Color.White;
            this.lbAutorLivro.Location = new System.Drawing.Point(240, 312);
            this.lbAutorLivro.Name = "lbAutorLivro";
            this.lbAutorLivro.Size = new System.Drawing.Size(65, 20);
            this.lbAutorLivro.TabIndex = 53;
            this.lbAutorLivro.Text = "Autor:*";
            // 
            // tbTituloLivro
            // 
            this.tbTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTituloLivro.ForeColor = System.Drawing.Color.Black;
            this.tbTituloLivro.Location = new System.Drawing.Point(244, 278);
            this.tbTituloLivro.Name = "tbTituloLivro";
            this.tbTituloLivro.Size = new System.Drawing.Size(590, 26);
            this.tbTituloLivro.TabIndex = 2;
            // 
            // lbTituloLivro
            // 
            this.lbTituloLivro.AutoSize = true;
            this.lbTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloLivro.ForeColor = System.Drawing.Color.White;
            this.lbTituloLivro.Location = new System.Drawing.Point(240, 240);
            this.lbTituloLivro.Name = "lbTituloLivro";
            this.lbTituloLivro.Size = new System.Drawing.Size(65, 20);
            this.lbTituloLivro.TabIndex = 51;
            this.lbTituloLivro.Text = "Título:*";
            // 
            // lbTituloObrigatorio
            // 
            this.lbTituloObrigatorio.AutoSize = true;
            this.lbTituloObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbTituloObrigatorio.Location = new System.Drawing.Point(668, 240);
            this.lbTituloObrigatorio.Name = "lbTituloObrigatorio";
            this.lbTituloObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbTituloObrigatorio.TabIndex = 75;
            this.lbTituloObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbEditoraObrigatorio
            // 
            this.lbEditoraObrigatorio.AutoSize = true;
            this.lbEditoraObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditoraObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbEditoraObrigatorio.Location = new System.Drawing.Point(369, 386);
            this.lbEditoraObrigatorio.Name = "lbEditoraObrigatorio";
            this.lbEditoraObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbEditoraObrigatorio.TabIndex = 76;
            this.lbEditoraObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbCategoriaObrigatorio
            // 
            this.lbCategoriaObrigatorio.AutoSize = true;
            this.lbCategoriaObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbCategoriaObrigatorio.Location = new System.Drawing.Point(668, 312);
            this.lbCategoriaObrigatorio.Name = "lbCategoriaObrigatorio";
            this.lbCategoriaObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbCategoriaObrigatorio.TabIndex = 77;
            this.lbCategoriaObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbAutorObrigatorio
            // 
            this.lbAutorObrigatorio.AutoSize = true;
            this.lbAutorObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutorObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbAutorObrigatorio.Location = new System.Drawing.Point(369, 312);
            this.lbAutorObrigatorio.Name = "lbAutorObrigatorio";
            this.lbAutorObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbAutorObrigatorio.TabIndex = 78;
            this.lbAutorObrigatorio.Text = "Campo Obrigatório*";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCodigo.ForeColor = System.Drawing.Color.Black;
            this.tbCodigo.Location = new System.Drawing.Point(315, 193);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(42, 26);
            this.tbCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(239, 196);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(70, 20);
            this.lbCodigo.TabIndex = 80;
            this.lbCodigo.Text = "Código:";
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.ForeColor = System.Drawing.Color.White;
            this.btnDesativar.Location = new System.Drawing.Point(583, 627);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(103, 41);
            this.btnDesativar.TabIndex = 11;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = false;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAno.ForeColor = System.Drawing.Color.Black;
            this.tbAno.Location = new System.Drawing.Point(244, 489);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(287, 26);
            this.tbAno.TabIndex = 7;
            // 
            // tbNumeroDePaginas
            // 
            this.tbNumeroDePaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNumeroDePaginas.ForeColor = System.Drawing.Color.Black;
            this.tbNumeroDePaginas.Location = new System.Drawing.Point(543, 488);
            this.tbNumeroDePaginas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbNumeroDePaginas.Name = "tbNumeroDePaginas";
            this.tbNumeroDePaginas.Size = new System.Drawing.Size(287, 26);
            this.tbNumeroDePaginas.TabIndex = 8;
            // 
            // lbEstoqueObrigatorio
            // 
            this.lbEstoqueObrigatorio.AutoSize = true;
            this.lbEstoqueObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstoqueObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbEstoqueObrigatorio.Location = new System.Drawing.Point(673, 386);
            this.lbEstoqueObrigatorio.Name = "lbEstoqueObrigatorio";
            this.lbEstoqueObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbEstoqueObrigatorio.TabIndex = 752;
            this.lbEstoqueObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbEstoque.ForeColor = System.Drawing.Color.White;
            this.lbEstoque.Location = new System.Drawing.Point(543, 386);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(88, 20);
            this.lbEstoque.TabIndex = 751;
            this.lbEstoque.Text = "Estoque:*";
            // 
            // tbEstoque
            // 
            this.tbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEstoque.ForeColor = System.Drawing.Color.Black;
            this.tbEstoque.Location = new System.Drawing.Point(547, 418);
            this.tbEstoque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(287, 26);
            this.tbEstoque.TabIndex = 6;
            // 
            // tbQuantidadeLivrosReservados
            // 
            this.tbQuantidadeLivrosReservados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbQuantidadeLivrosReservados.ForeColor = System.Drawing.Color.Black;
            this.tbQuantidadeLivrosReservados.Location = new System.Drawing.Point(244, 555);
            this.tbQuantidadeLivrosReservados.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbQuantidadeLivrosReservados.Name = "tbQuantidadeLivrosReservados";
            this.tbQuantidadeLivrosReservados.Size = new System.Drawing.Size(287, 26);
            this.tbQuantidadeLivrosReservados.TabIndex = 9;
            // 
            // lbQuantidadeLivrosReservados
            // 
            this.lbQuantidadeLivrosReservados.AutoSize = true;
            this.lbQuantidadeLivrosReservados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeLivrosReservados.ForeColor = System.Drawing.Color.White;
            this.lbQuantidadeLivrosReservados.Location = new System.Drawing.Point(246, 524);
            this.lbQuantidadeLivrosReservados.Name = "lbQuantidadeLivrosReservados";
            this.lbQuantidadeLivrosReservados.Size = new System.Drawing.Size(259, 20);
            this.lbQuantidadeLivrosReservados.TabIndex = 754;
            this.lbQuantidadeLivrosReservados.Text = "Quantidade Livros Reservados:";
            // 
            // NovoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.tbQuantidadeLivrosReservados);
            this.Controls.Add(this.lbQuantidadeLivrosReservados);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.lbEstoqueObrigatorio);
            this.Controls.Add(this.lbEstoque);
            this.Controls.Add(this.tbNumeroDePaginas);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbAutorObrigatorio);
            this.Controls.Add(this.lbCategoriaObrigatorio);
            this.Controls.Add(this.lbEditoraObrigatorio);
            this.Controls.Add(this.lbTituloObrigatorio);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.tbEditora);
            this.Controls.Add(this.lbEditora);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.lbAutorLivro);
            this.Controls.Add(this.tbTituloLivro);
            this.Controls.Add(this.lbTituloLivro);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 815);
            this.MinimumSize = new System.Drawing.Size(1051, 815);
            this.Name = "NovoLivro";
            this.Text = "NovoLivro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDePaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantidadeLivrosReservados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloNovoLivro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Label lbEditora;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lbAutorLivro;
        private System.Windows.Forms.TextBox tbTituloLivro;
        private System.Windows.Forms.Label lbTituloLivro;
        private System.Windows.Forms.Label lbTituloObrigatorio;
        private System.Windows.Forms.Label lbEditoraObrigatorio;
        private System.Windows.Forms.Label lbCategoriaObrigatorio;
        private System.Windows.Forms.Label lbAutorObrigatorio;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.NumericUpDown tbNumeroDePaginas;
        private System.Windows.Forms.Label lbEstoqueObrigatorio;
        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.NumericUpDown tbEstoque;
        private System.Windows.Forms.NumericUpDown tbQuantidadeLivrosReservados;
        private System.Windows.Forms.Label lbQuantidadeLivrosReservados;
    }
}