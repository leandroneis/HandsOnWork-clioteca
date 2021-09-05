
namespace Biblioteca.Formularios.Livros
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
            this.tbAno = new System.Windows.Forms.MaskedTextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.tbNumeroDePaginas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.lbEditora = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lbAutorLivro = new System.Windows.Forms.Label();
            this.tbTituloLivro = new System.Windows.Forms.TextBox();
            this.lbTituloLivro = new System.Windows.Forms.Label();
            this.lbTituloObrigatorio = new System.Windows.Forms.Label();
            this.lbEditoraObrigatorio = new System.Windows.Forms.Label();
            this.lbAssuntoObrigatorio = new System.Windows.Forms.Label();
            this.lbAutorObrigatorio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.btnLimpar.Location = new System.Drawing.Point(509, 642);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 41);
            this.btnLimpar.TabIndex = 74;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(383, 642);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 41);
            this.btnSalvar.TabIndex = 73;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbAno.Location = new System.Drawing.Point(244, 567);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(590, 22);
            this.tbAno.TabIndex = 66;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.ForeColor = System.Drawing.Color.White;
            this.lbCep.Location = new System.Drawing.Point(240, 535);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(46, 20);
            this.lbCep.TabIndex = 65;
            this.lbCep.Text = "Ano:";
            // 
            // tbNumeroDePaginas
            // 
            this.tbNumeroDePaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbNumeroDePaginas.Location = new System.Drawing.Point(244, 493);
            this.tbNumeroDePaginas.Name = "tbNumeroDePaginas";
            this.tbNumeroDePaginas.Size = new System.Drawing.Size(590, 22);
            this.tbNumeroDePaginas.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "N° de Pág:";
            // 
            // tbAssunto
            // 
            this.tbAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAssunto.Location = new System.Drawing.Point(244, 343);
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(590, 22);
            this.tbAssunto.TabIndex = 60;
            // 
            // lbAssunto
            // 
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssunto.ForeColor = System.Drawing.Color.White;
            this.lbAssunto.Location = new System.Drawing.Point(244, 311);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(87, 20);
            this.lbAssunto.TabIndex = 59;
            this.lbAssunto.Text = "Assunto:*";
            // 
            // tbEditora
            // 
            this.tbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbEditora.Location = new System.Drawing.Point(244, 414);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(590, 22);
            this.tbEditora.TabIndex = 56;
            // 
            // lbEditora
            // 
            this.lbEditora.AutoSize = true;
            this.lbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbEditora.ForeColor = System.Drawing.Color.White;
            this.lbEditora.Location = new System.Drawing.Point(240, 382);
            this.lbEditora.Name = "lbEditora";
            this.lbEditora.Size = new System.Drawing.Size(79, 20);
            this.lbEditora.TabIndex = 55;
            this.lbEditora.Text = "Editora:*";
            // 
            // tbAutor
            // 
            this.tbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbAutor.Location = new System.Drawing.Point(244, 279);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(590, 22);
            this.tbAutor.TabIndex = 54;
            // 
            // lbAutorLivro
            // 
            this.lbAutorLivro.AutoSize = true;
            this.lbAutorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbAutorLivro.ForeColor = System.Drawing.Color.White;
            this.lbAutorLivro.Location = new System.Drawing.Point(240, 247);
            this.lbAutorLivro.Name = "lbAutorLivro";
            this.lbAutorLivro.Size = new System.Drawing.Size(65, 20);
            this.lbAutorLivro.TabIndex = 53;
            this.lbAutorLivro.Text = "Autor:*";
            // 
            // tbTituloLivro
            // 
            this.tbTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTituloLivro.Location = new System.Drawing.Point(244, 213);
            this.tbTituloLivro.Name = "tbTituloLivro";
            this.tbTituloLivro.Size = new System.Drawing.Size(590, 22);
            this.tbTituloLivro.TabIndex = 52;
            // 
            // lbTituloLivro
            // 
            this.lbTituloLivro.AutoSize = true;
            this.lbTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloLivro.ForeColor = System.Drawing.Color.White;
            this.lbTituloLivro.Location = new System.Drawing.Point(240, 175);
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
            this.lbTituloObrigatorio.Location = new System.Drawing.Point(668, 175);
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
            this.lbEditoraObrigatorio.Location = new System.Drawing.Point(668, 382);
            this.lbEditoraObrigatorio.Name = "lbEditoraObrigatorio";
            this.lbEditoraObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbEditoraObrigatorio.TabIndex = 76;
            this.lbEditoraObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbAssuntoObrigatorio
            // 
            this.lbAssuntoObrigatorio.AutoSize = true;
            this.lbAssuntoObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssuntoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbAssuntoObrigatorio.Location = new System.Drawing.Point(668, 311);
            this.lbAssuntoObrigatorio.Name = "lbAssuntoObrigatorio";
            this.lbAssuntoObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbAssuntoObrigatorio.TabIndex = 77;
            this.lbAssuntoObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbAutorObrigatorio
            // 
            this.lbAutorObrigatorio.AutoSize = true;
            this.lbAutorObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutorObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbAutorObrigatorio.Location = new System.Drawing.Point(668, 247);
            this.lbAutorObrigatorio.Name = "lbAutorObrigatorio";
            this.lbAutorObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbAutorObrigatorio.TabIndex = 78;
            this.lbAutorObrigatorio.Text = "Campo Obrigatório*";
            // 
            // NovoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.lbAutorObrigatorio);
            this.Controls.Add(this.lbAssuntoObrigatorio);
            this.Controls.Add(this.lbEditoraObrigatorio);
            this.Controls.Add(this.lbTituloObrigatorio);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.tbNumeroDePaginas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAssunto);
            this.Controls.Add(this.lbAssunto);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloNovoLivro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox tbAno;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox tbNumeroDePaginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Label lbEditora;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lbAutorLivro;
        private System.Windows.Forms.TextBox tbTituloLivro;
        private System.Windows.Forms.Label lbTituloLivro;
        private System.Windows.Forms.Label lbTituloObrigatorio;
        private System.Windows.Forms.Label lbEditoraObrigatorio;
        private System.Windows.Forms.Label lbAssuntoObrigatorio;
        private System.Windows.Forms.Label lbAutorObrigatorio;
    }
}