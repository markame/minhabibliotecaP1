namespace minhabiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plMain = new Panel();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            novoLivroToolStripMenuItem = new ToolStripMenuItem();
            editarLivrosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            buscarLivrosToolStripMenuItem = new ToolStripMenuItem();
            deletarLivrosToolStripMenuItem = new ToolStripMenuItem();
            impressorasToolStripMenuItem = new ToolStripMenuItem();
            bancosDeDadosToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            plMain.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // plMain
            // 
            plMain.Controls.Add(menuStrip1);
            plMain.Location = new Point(12, 12);
            plMain.Name = "plMain";
            plMain.Size = new Size(1240, 737);
            plMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, buscarToolStripMenuItem, configuraçõesToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1240, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoLivroToolStripMenuItem, editarLivrosToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarLivrosToolStripMenuItem, deletarLivrosToolStripMenuItem });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(54, 20);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impressorasToolStripMenuItem, bancosDeDadosToolStripMenuItem, usuáriosToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // novoLivroToolStripMenuItem
            // 
            novoLivroToolStripMenuItem.Name = "novoLivroToolStripMenuItem";
            novoLivroToolStripMenuItem.Size = new Size(180, 22);
            novoLivroToolStripMenuItem.Text = "Novo livro";
            // 
            // editarLivrosToolStripMenuItem
            // 
            editarLivrosToolStripMenuItem.Name = "editarLivrosToolStripMenuItem";
            editarLivrosToolStripMenuItem.Size = new Size(180, 22);
            editarLivrosToolStripMenuItem.Text = "Editar Livros";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // buscarLivrosToolStripMenuItem
            // 
            buscarLivrosToolStripMenuItem.Name = "buscarLivrosToolStripMenuItem";
            buscarLivrosToolStripMenuItem.Size = new Size(180, 22);
            buscarLivrosToolStripMenuItem.Text = "Buscar Livros";
            // 
            // deletarLivrosToolStripMenuItem
            // 
            deletarLivrosToolStripMenuItem.Name = "deletarLivrosToolStripMenuItem";
            deletarLivrosToolStripMenuItem.Size = new Size(180, 22);
            deletarLivrosToolStripMenuItem.Text = "Deletar Livros";
            // 
            // impressorasToolStripMenuItem
            // 
            impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            impressorasToolStripMenuItem.Size = new Size(180, 22);
            impressorasToolStripMenuItem.Text = "Impressoras";
            // 
            // bancosDeDadosToolStripMenuItem
            // 
            bancosDeDadosToolStripMenuItem.Name = "bancosDeDadosToolStripMenuItem";
            bancosDeDadosToolStripMenuItem.Size = new Size(180, 22);
            bancosDeDadosToolStripMenuItem.Text = "Bancos de dados";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarUsuáriosToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(180, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // gerenciarUsuáriosToolStripMenuItem
            // 
            gerenciarUsuáriosToolStripMenuItem.Name = "gerenciarUsuáriosToolStripMenuItem";
            gerenciarUsuáriosToolStripMenuItem.Size = new Size(180, 22);
            gerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar usuários";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(plMain);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minha biblioteca";
            plMain.ResumeLayout(false);
            plMain.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoLivroToolStripMenuItem;
        private ToolStripMenuItem editarLivrosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem buscarLivrosToolStripMenuItem;
        private ToolStripMenuItem deletarLivrosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem impressorasToolStripMenuItem;
        private ToolStripMenuItem bancosDeDadosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem;
    }
}
