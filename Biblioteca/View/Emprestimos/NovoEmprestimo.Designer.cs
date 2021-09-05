
namespace Biblioteca.Formularios.Emprestimos
{
    partial class NovoEmprestimo
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
            this.lbTituloNovoEmprestimo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbEmprestimoCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.lbLivro = new System.Windows.Forms.Label();
            this.lbDataEmprestimo = new System.Windows.Forms.Label();
            this.dtDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dtDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lbDataDevolução = new System.Windows.Forms.Label();
            this.lbClienteObrigatorio = new System.Windows.Forms.Label();
            this.lbLivroObrigatorio = new System.Windows.Forms.Label();
            this.lbDataEmprestimoObrigatorio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.lbTituloNovoEmprestimo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1051, 144);
            this.panel1.MinimumSize = new System.Drawing.Size(1051, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 144);
            this.panel1.TabIndex = 0;
            // 
            // lbTituloNovoEmprestimo
            // 
            this.lbTituloNovoEmprestimo.AutoSize = true;
            this.lbTituloNovoEmprestimo.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloNovoEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lbTituloNovoEmprestimo.Location = new System.Drawing.Point(304, 42);
            this.lbTituloNovoEmprestimo.Name = "lbTituloNovoEmprestimo";
            this.lbTituloNovoEmprestimo.Size = new System.Drawing.Size(362, 54);
            this.lbTituloNovoEmprestimo.TabIndex = 3;
            this.lbTituloNovoEmprestimo.Text = "Novo Empréstimo";
            this.lbTituloNovoEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(509, 642);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 41);
            this.btnLimpar.TabIndex = 50;
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
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbEmprestimoCliente
            // 
            this.lbEmprestimoCliente.AutoSize = true;
            this.lbEmprestimoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmprestimoCliente.ForeColor = System.Drawing.Color.White;
            this.lbEmprestimoCliente.Location = new System.Drawing.Point(309, 192);
            this.lbEmprestimoCliente.Name = "lbEmprestimoCliente";
            this.lbEmprestimoCliente.Size = new System.Drawing.Size(70, 20);
            this.lbEmprestimoCliente.TabIndex = 27;
            this.lbEmprestimoCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(313, 229);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(413, 21);
            this.cbCliente.TabIndex = 51;
            this.cbCliente.Text = "Selecione um cliente";
            // 
            // cbLivro
            // 
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(313, 309);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(413, 21);
            this.cbLivro.TabIndex = 53;
            this.cbLivro.Text = "Selecione um Livro";
            // 
            // lbLivro
            // 
            this.lbLivro.AutoSize = true;
            this.lbLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivro.ForeColor = System.Drawing.Color.White;
            this.lbLivro.Location = new System.Drawing.Point(309, 272);
            this.lbLivro.Name = "lbLivro";
            this.lbLivro.Size = new System.Drawing.Size(52, 20);
            this.lbLivro.TabIndex = 52;
            this.lbLivro.Text = "Livro:";
            // 
            // lbDataEmprestimo
            // 
            this.lbDataEmprestimo.AutoSize = true;
            this.lbDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lbDataEmprestimo.Location = new System.Drawing.Point(309, 355);
            this.lbDataEmprestimo.Name = "lbDataEmprestimo";
            this.lbDataEmprestimo.Size = new System.Drawing.Size(178, 20);
            this.lbDataEmprestimo.TabIndex = 54;
            this.lbDataEmprestimo.Text = "Data do Empréstimo:";
            // 
            // dtDataEmprestimo
            // 
            this.dtDataEmprestimo.Location = new System.Drawing.Point(313, 398);
            this.dtDataEmprestimo.Name = "dtDataEmprestimo";
            this.dtDataEmprestimo.Size = new System.Drawing.Size(413, 20);
            this.dtDataEmprestimo.TabIndex = 55;
            // 
            // dtDataDevolucao
            // 
            this.dtDataDevolucao.Location = new System.Drawing.Point(313, 494);
            this.dtDataDevolucao.Name = "dtDataDevolucao";
            this.dtDataDevolucao.Size = new System.Drawing.Size(413, 20);
            this.dtDataDevolucao.TabIndex = 57;
            // 
            // lbDataDevolução
            // 
            this.lbDataDevolução.AutoSize = true;
            this.lbDataDevolução.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDevolução.ForeColor = System.Drawing.Color.White;
            this.lbDataDevolução.Location = new System.Drawing.Point(309, 451);
            this.lbDataDevolução.Name = "lbDataDevolução";
            this.lbDataDevolução.Size = new System.Drawing.Size(167, 20);
            this.lbDataDevolução.TabIndex = 56;
            this.lbDataDevolução.Text = "Data da Devolução:";
            // 
            // lbClienteObrigatorio
            // 
            this.lbClienteObrigatorio.AutoSize = true;
            this.lbClienteObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbClienteObrigatorio.Location = new System.Drawing.Point(560, 192);
            this.lbClienteObrigatorio.Name = "lbClienteObrigatorio";
            this.lbClienteObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbClienteObrigatorio.TabIndex = 76;
            this.lbClienteObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbLivroObrigatorio
            // 
            this.lbLivroObrigatorio.AutoSize = true;
            this.lbLivroObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivroObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbLivroObrigatorio.Location = new System.Drawing.Point(560, 272);
            this.lbLivroObrigatorio.Name = "lbLivroObrigatorio";
            this.lbLivroObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbLivroObrigatorio.TabIndex = 77;
            this.lbLivroObrigatorio.Text = "Campo Obrigatório*";
            // 
            // lbDataEmprestimoObrigatorio
            // 
            this.lbDataEmprestimoObrigatorio.AutoSize = true;
            this.lbDataEmprestimoObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEmprestimoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lbDataEmprestimoObrigatorio.Location = new System.Drawing.Point(560, 355);
            this.lbDataEmprestimoObrigatorio.Name = "lbDataEmprestimoObrigatorio";
            this.lbDataEmprestimoObrigatorio.Size = new System.Drawing.Size(166, 20);
            this.lbDataEmprestimoObrigatorio.TabIndex = 78;
            this.lbDataEmprestimoObrigatorio.Text = "Campo Obrigatório*";
            // 
            // NovoEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.lbDataEmprestimoObrigatorio);
            this.Controls.Add(this.lbLivroObrigatorio);
            this.Controls.Add(this.lbClienteObrigatorio);
            this.Controls.Add(this.dtDataDevolucao);
            this.Controls.Add(this.lbDataDevolução);
            this.Controls.Add(this.dtDataEmprestimo);
            this.Controls.Add(this.lbDataEmprestimo);
            this.Controls.Add(this.cbLivro);
            this.Controls.Add(this.lbLivro);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbEmprestimoCliente);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 815);
            this.MinimumSize = new System.Drawing.Size(1051, 815);
            this.Name = "NovoEmprestimo";
            this.Text = "NovoEmprestimo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloNovoEmprestimo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbEmprestimoCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.Label lbLivro;
        private System.Windows.Forms.Label lbDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtDataDevolucao;
        private System.Windows.Forms.Label lbDataDevolução;
        private System.Windows.Forms.Label lbClienteObrigatorio;
        private System.Windows.Forms.Label lbLivroObrigatorio;
        private System.Windows.Forms.Label lbDataEmprestimoObrigatorio;
    }
}