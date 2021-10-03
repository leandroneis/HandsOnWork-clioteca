
namespace Biblioteca.View.Clientes
{
    partial class PesquisarClientes
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTituloPesquisarClientes = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbCodigoCliente = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCodigoMsg = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.NumericUpDown();
            this.pesquisarClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pesquisarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisarClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisarClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.lbTituloPesquisarClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1051, 144);
            this.panel1.MinimumSize = new System.Drawing.Size(1051, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 144);
            this.panel1.TabIndex = 0;
            // 
            // lbTituloPesquisarClientes
            // 
            this.lbTituloPesquisarClientes.AutoSize = true;
            this.lbTituloPesquisarClientes.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPesquisarClientes.ForeColor = System.Drawing.Color.White;
            this.lbTituloPesquisarClientes.Location = new System.Drawing.Point(300, 47);
            this.lbTituloPesquisarClientes.Name = "lbTituloPesquisarClientes";
            this.lbTituloPesquisarClientes.Size = new System.Drawing.Size(363, 54);
            this.lbTituloPesquisarClientes.TabIndex = 3;
            this.lbTituloPesquisarClientes.Text = "Pesquisar Clientes";
            this.lbTituloPesquisarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNome.Location = new System.Drawing.Point(328, 202);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(278, 26);
            this.tbNome.TabIndex = 2;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lbNomeCliente.Location = new System.Drawing.Point(262, 202);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(60, 20);
            this.lbNomeCliente.TabIndex = 8;
            this.lbNomeCliente.Text = "Nome:";
            // 
            // lbCodigoCliente
            // 
            this.lbCodigoCliente.AutoSize = true;
            this.lbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCliente.ForeColor = System.Drawing.Color.White;
            this.lbCodigoCliente.Location = new System.Drawing.Point(252, 165);
            this.lbCodigoCliente.Name = "lbCodigoCliente";
            this.lbCodigoCliente.Size = new System.Drawing.Size(70, 20);
            this.lbCodigoCliente.TabIndex = 6;
            this.lbCodigoCliente.Text = "Código:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(489, 257);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(341, 257);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(127, 41);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome_completo,
            this.email,
            this.telefone,
            this.ativo});
            this.dgClientes.Location = new System.Drawing.Point(12, 337);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.Size = new System.Drawing.Size(1011, 427);
            this.dgClientes.TabIndex = 5;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            this.dgClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome_completo
            // 
            this.nome_completo.DataPropertyName = "nome_completo";
            this.nome_completo.Frozen = true;
            this.nome_completo.HeaderText = "Nome Completo";
            this.nome_completo.Name = "nome_completo";
            this.nome_completo.ReadOnly = true;
            this.nome_completo.Width = 411;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.Frozen = true;
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.Frozen = true;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 150;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.Frozen = true;
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Width = 150;
            // 
            // lbCodigoMsg
            // 
            this.lbCodigoMsg.AutoSize = true;
            this.lbCodigoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoMsg.ForeColor = System.Drawing.Color.Red;
            this.lbCodigoMsg.Location = new System.Drawing.Point(612, 167);
            this.lbCodigoMsg.Name = "lbCodigoMsg";
            this.lbCodigoMsg.Size = new System.Drawing.Size(220, 20);
            this.lbCodigoMsg.TabIndex = 30;
            this.lbCodigoMsg.Text = "O Código não pode ser 0!*";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCodigo.Location = new System.Drawing.Point(328, 167);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(10);
            this.tbCodigo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(278, 26);
            this.tbCodigo.TabIndex = 31;
            // 
            // pesquisarClientesBindingSource1
            // 
            this.pesquisarClientesBindingSource1.DataSource = typeof(Biblioteca.View.Clientes.PesquisarClientes);
            // 
            // pesquisarClientesBindingSource
            // 
            this.pesquisarClientesBindingSource.DataSource = typeof(Biblioteca.View.Clientes.PesquisarClientes);
            // 
            // PesquisarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigoMsg);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.lbCodigoCliente);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 815);
            this.MinimumSize = new System.Drawing.Size(1051, 815);
            this.Name = "PesquisarClientes";
            this.Text = "PesquisarClientes";
            this.Load += new System.EventHandler(this.PesquisarClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisarClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisarClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloPesquisarClientes;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbCodigoCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.BindingSource pesquisarClientesBindingSource;
        private System.Windows.Forms.BindingSource pesquisarClientesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.Label lbCodigoMsg;
        private System.Windows.Forms.NumericUpDown tbCodigo;
    }
}