
namespace Biblioteca
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnSubMenuLivros = new System.Windows.Forms.Panel();
            this.btnPesquisarLivros = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.pnSubMenuEmprestimos = new System.Windows.Forms.Panel();
            this.btnPesquisarEmprestimos = new System.Windows.Forms.Button();
            this.btnNovoEmprestimo = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.pnSubMenuClientes = new System.Windows.Forms.Panel();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnChildForm = new System.Windows.Forms.Panel();
            this.pnMainTitulo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pcLogoCorpo = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.pnSubMenuLivros.SuspendLayout();
            this.pnSubMenuEmprestimos.SuspendLayout();
            this.pnSubMenuClientes.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnChildForm.SuspendLayout();
            this.pnMainTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogoCorpo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnMenu.Controls.Add(this.pnSubMenuLivros);
            this.pnMenu.Controls.Add(this.btnLivro);
            this.pnMenu.Controls.Add(this.pnSubMenuEmprestimos);
            this.pnMenu.Controls.Add(this.btnEmprestimo);
            this.pnMenu.Controls.Add(this.pnSubMenuClientes);
            this.pnMenu.Controls.Add(this.btnCliente);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.MaximumSize = new System.Drawing.Size(186, 815);
            this.pnMenu.MinimumSize = new System.Drawing.Size(186, 815);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(186, 815);
            this.pnMenu.TabIndex = 0;
            // 
            // pnSubMenuLivros
            // 
            this.pnSubMenuLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnSubMenuLivros.Controls.Add(this.btnPesquisarLivros);
            this.pnSubMenuLivros.Controls.Add(this.btnNovoLivro);
            this.pnSubMenuLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuLivros.Location = new System.Drawing.Point(0, 470);
            this.pnSubMenuLivros.MaximumSize = new System.Drawing.Size(186, 100);
            this.pnSubMenuLivros.MinimumSize = new System.Drawing.Size(186, 100);
            this.pnSubMenuLivros.Name = "pnSubMenuLivros";
            this.pnSubMenuLivros.Size = new System.Drawing.Size(186, 100);
            this.pnSubMenuLivros.TabIndex = 1;
            // 
            // btnPesquisarLivros
            // 
            this.btnPesquisarLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarLivros.FlatAppearance.BorderSize = 0;
            this.btnPesquisarLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarLivros.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarLivros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPesquisarLivros.Location = new System.Drawing.Point(0, 42);
            this.btnPesquisarLivros.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnPesquisarLivros.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnPesquisarLivros.Name = "btnPesquisarLivros";
            this.btnPesquisarLivros.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPesquisarLivros.Size = new System.Drawing.Size(186, 42);
            this.btnPesquisarLivros.TabIndex = 26;
            this.btnPesquisarLivros.Text = "Pesquisar Livros";
            this.btnPesquisarLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisarLivros.UseVisualStyleBackColor = true;
            this.btnPesquisarLivros.Click += new System.EventHandler(this.btnPesquisarLivros_Click);
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoLivro.FlatAppearance.BorderSize = 0;
            this.btnNovoLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoLivro.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNovoLivro.Location = new System.Drawing.Point(0, 0);
            this.btnNovoLivro.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnNovoLivro.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNovoLivro.Size = new System.Drawing.Size(186, 42);
            this.btnNovoLivro.TabIndex = 25;
            this.btnNovoLivro.Text = "Novo Livro";
            this.btnNovoLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLivro.Image = ((System.Drawing.Image)(resources.GetObject("btnLivro.Image")));
            this.btnLivro.Location = new System.Drawing.Point(0, 428);
            this.btnLivro.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnLivro.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLivro.Size = new System.Drawing.Size(186, 42);
            this.btnLivro.TabIndex = 20;
            this.btnLivro.Text = "Livros";
            this.btnLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // pnSubMenuEmprestimos
            // 
            this.pnSubMenuEmprestimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnSubMenuEmprestimos.Controls.Add(this.btnPesquisarEmprestimos);
            this.pnSubMenuEmprestimos.Controls.Add(this.btnNovoEmprestimo);
            this.pnSubMenuEmprestimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuEmprestimos.Location = new System.Drawing.Point(0, 328);
            this.pnSubMenuEmprestimos.MaximumSize = new System.Drawing.Size(186, 100);
            this.pnSubMenuEmprestimos.MinimumSize = new System.Drawing.Size(186, 100);
            this.pnSubMenuEmprestimos.Name = "pnSubMenuEmprestimos";
            this.pnSubMenuEmprestimos.Size = new System.Drawing.Size(186, 100);
            this.pnSubMenuEmprestimos.TabIndex = 19;
            // 
            // btnPesquisarEmprestimos
            // 
            this.btnPesquisarEmprestimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarEmprestimos.FlatAppearance.BorderSize = 0;
            this.btnPesquisarEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarEmprestimos.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEmprestimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPesquisarEmprestimos.Location = new System.Drawing.Point(0, 42);
            this.btnPesquisarEmprestimos.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnPesquisarEmprestimos.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnPesquisarEmprestimos.Name = "btnPesquisarEmprestimos";
            this.btnPesquisarEmprestimos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPesquisarEmprestimos.Size = new System.Drawing.Size(186, 42);
            this.btnPesquisarEmprestimos.TabIndex = 24;
            this.btnPesquisarEmprestimos.Text = "Pesquisar Empréstimos";
            this.btnPesquisarEmprestimos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarEmprestimos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisarEmprestimos.UseVisualStyleBackColor = true;
            this.btnPesquisarEmprestimos.Click += new System.EventHandler(this.btnPesquisarEmprestimos_Click);
            // 
            // btnNovoEmprestimo
            // 
            this.btnNovoEmprestimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnNovoEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoEmprestimo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNovoEmprestimo.Location = new System.Drawing.Point(0, 0);
            this.btnNovoEmprestimo.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnNovoEmprestimo.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnNovoEmprestimo.Name = "btnNovoEmprestimo";
            this.btnNovoEmprestimo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNovoEmprestimo.Size = new System.Drawing.Size(186, 42);
            this.btnNovoEmprestimo.TabIndex = 23;
            this.btnNovoEmprestimo.Text = "Novo Empréstimo";
            this.btnNovoEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovoEmprestimo.UseVisualStyleBackColor = true;
            this.btnNovoEmprestimo.Click += new System.EventHandler(this.btnNovoEmprestimo_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btnEmprestimo.Image")));
            this.btnEmprestimo.Location = new System.Drawing.Point(0, 286);
            this.btnEmprestimo.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnEmprestimo.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmprestimo.Size = new System.Drawing.Size(186, 42);
            this.btnEmprestimo.TabIndex = 18;
            this.btnEmprestimo.Text = "Empréstimos";
            this.btnEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // pnSubMenuClientes
            // 
            this.pnSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnSubMenuClientes.Controls.Add(this.btnPesquisarCliente);
            this.pnSubMenuClientes.Controls.Add(this.btnNovoCliente);
            this.pnSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuClientes.Location = new System.Drawing.Point(0, 186);
            this.pnSubMenuClientes.MaximumSize = new System.Drawing.Size(186, 100);
            this.pnSubMenuClientes.MinimumSize = new System.Drawing.Size(186, 100);
            this.pnSubMenuClientes.Name = "pnSubMenuClientes";
            this.pnSubMenuClientes.Size = new System.Drawing.Size(186, 100);
            this.pnSubMenuClientes.TabIndex = 17;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(0, 42);
            this.btnPesquisarCliente.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnPesquisarCliente.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPesquisarCliente.Size = new System.Drawing.Size(186, 42);
            this.btnPesquisarCliente.TabIndex = 22;
            this.btnPesquisarCliente.Text = "Pesquisar Clientes";
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNovoCliente.Location = new System.Drawing.Point(0, 0);
            this.btnNovoCliente.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnNovoCliente.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNovoCliente.Size = new System.Drawing.Size(186, 42);
            this.btnNovoCliente.TabIndex = 21;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(0, 144);
            this.btnCliente.MaximumSize = new System.Drawing.Size(186, 42);
            this.btnCliente.MinimumSize = new System.Drawing.Size(186, 42);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(186, 42);
            this.btnCliente.TabIndex = 16;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.lbUserName);
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.MaximumSize = new System.Drawing.Size(186, 144);
            this.pnLogo.MinimumSize = new System.Drawing.Size(186, 144);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(186, 144);
            this.pnLogo.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lbUserName.Location = new System.Drawing.Point(61, 98);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(62, 16);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(63, 63);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(63, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnChildForm
            // 
            this.pnChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnChildForm.Controls.Add(this.pcLogoCorpo);
            this.pnChildForm.Controls.Add(this.pnMainTitulo);
            this.pnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChildForm.Location = new System.Drawing.Point(186, 0);
            this.pnChildForm.Name = "pnChildForm";
            this.pnChildForm.Size = new System.Drawing.Size(1051, 815);
            this.pnChildForm.TabIndex = 2;
            // 
            // pnMainTitulo
            // 
            this.pnMainTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(176)))));
            this.pnMainTitulo.Controls.Add(this.lbTitulo);
            this.pnMainTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMainTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnMainTitulo.Name = "pnMainTitulo";
            this.pnMainTitulo.Size = new System.Drawing.Size(1051, 144);
            this.pnMainTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(388, 45);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(206, 54);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "CLIOTECA";
            // 
            // pcLogoCorpo
            // 
            this.pcLogoCorpo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogoCorpo.Image")));
            this.pcLogoCorpo.Location = new System.Drawing.Point(180, 174);
            this.pcLogoCorpo.Name = "pcLogoCorpo";
            this.pcLogoCorpo.Size = new System.Drawing.Size(650, 608);
            this.pcLogoCorpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogoCorpo.TabIndex = 1;
            this.pcLogoCorpo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 815);
            this.Controls.Add(this.pnChildForm);
            this.Controls.Add(this.pnMenu);
            this.MaximumSize = new System.Drawing.Size(1253, 854);
            this.Name = "Main";
            this.Text = "Clioteca";
            this.pnMenu.ResumeLayout(false);
            this.pnSubMenuLivros.ResumeLayout(false);
            this.pnSubMenuEmprestimos.ResumeLayout(false);
            this.pnSubMenuClientes.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnChildForm.ResumeLayout(false);
            this.pnMainTitulo.ResumeLayout(false);
            this.pnMainTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogoCorpo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnChildForm;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnMainTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel pnSubMenuClientes;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Panel pnSubMenuEmprestimos;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Panel pnSubMenuLivros;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnPesquisarLivros;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Button btnPesquisarEmprestimos;
        private System.Windows.Forms.Button btnNovoEmprestimo;
        private System.Windows.Forms.PictureBox pcLogoCorpo;
    }
}

