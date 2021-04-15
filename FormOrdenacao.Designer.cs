namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanhoInicialDoVetorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.preenchimentoInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.preenchimentoInicialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preenchimentoInicialToolStripMenuItem1,
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.mergeToolStripMenuItem1});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.quickSortToolStripMenuItem.Text = "QuickSort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.heapSortToolStripMenuItem.Text = "HeapSort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem1
            // 
            this.mergeToolStripMenuItem1.Name = "mergeToolStripMenuItem1";
            this.mergeToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.mergeToolStripMenuItem1.Text = "Merge";
            this.mergeToolStripMenuItem1.Click += new System.EventHandler(this.mergeToolStripMenuItem1_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamanhoInicialDoVetorToolStripMenuItem,
            this.preenchimentoInicialToolStripMenuItem,
            this.bolhaToolStripMenuItem1,
            this.seleçãoToolStripMenuItem1,
            this.inserçãoToolStripMenuItem1,
            this.shellSortToolStripMenuItem1,
            this.quickSortToolStripMenuItem1,
            this.heapSortToolStripMenuItem1,
            this.mergeToolStripMenuItem});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // tamanhoInicialDoVetorToolStripMenuItem
            // 
            this.tamanhoInicialDoVetorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.tamanhoInicialDoVetorToolStripMenuItem.Name = "tamanhoInicialDoVetorToolStripMenuItem";
            this.tamanhoInicialDoVetorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tamanhoInicialDoVetorToolStripMenuItem.Text = "Tamanho inicial do vetor";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem2.Text = "1.000";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem3.Text = "10.000";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem4.Text = "50.000";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem5.Text = "100.000";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem6.Text = "500.000";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // preenchimentoInicialToolStripMenuItem
            // 
            this.preenchimentoInicialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem,
            this.decrescenteToolStripMenuItem,
            this.aleatórioToolStripMenuItem});
            this.preenchimentoInicialToolStripMenuItem.Name = "preenchimentoInicialToolStripMenuItem";
            this.preenchimentoInicialToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.preenchimentoInicialToolStripMenuItem.Text = "Preenchimento inicial";
            // 
            // crescenteToolStripMenuItem
            // 
            this.crescenteToolStripMenuItem.Name = "crescenteToolStripMenuItem";
            this.crescenteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.crescenteToolStripMenuItem.Text = "Crescente";
            this.crescenteToolStripMenuItem.Click += new System.EventHandler(this.crescenteToolStripMenuItem_Click);
            // 
            // decrescenteToolStripMenuItem
            // 
            this.decrescenteToolStripMenuItem.Name = "decrescenteToolStripMenuItem";
            this.decrescenteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.decrescenteToolStripMenuItem.Text = "Decrescente";
            this.decrescenteToolStripMenuItem.Click += new System.EventHandler(this.decrescenteToolStripMenuItem_Click);
            // 
            // aleatórioToolStripMenuItem
            // 
            this.aleatórioToolStripMenuItem.Name = "aleatórioToolStripMenuItem";
            this.aleatórioToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem.Text = "Aleatório";
            this.aleatórioToolStripMenuItem.Click += new System.EventHandler(this.aleatórioToolStripMenuItem_Click);
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // seleçãoToolStripMenuItem1
            // 
            this.seleçãoToolStripMenuItem1.Name = "seleçãoToolStripMenuItem1";
            this.seleçãoToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.seleçãoToolStripMenuItem1.Text = "Seleção";
            this.seleçãoToolStripMenuItem1.Click += new System.EventHandler(this.seleçãoToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            this.inserçãoToolStripMenuItem1.Click += new System.EventHandler(this.inserçãoToolStripMenuItem1_Click);
            // 
            // shellSortToolStripMenuItem1
            // 
            this.shellSortToolStripMenuItem1.Name = "shellSortToolStripMenuItem1";
            this.shellSortToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.shellSortToolStripMenuItem1.Text = "ShellSort";
            this.shellSortToolStripMenuItem1.Click += new System.EventHandler(this.shellSortToolStripMenuItem1_Click);
            // 
            // quickSortToolStripMenuItem1
            // 
            this.quickSortToolStripMenuItem1.Name = "quickSortToolStripMenuItem1";
            this.quickSortToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.quickSortToolStripMenuItem1.Text = "QuickSort";
            this.quickSortToolStripMenuItem1.Click += new System.EventHandler(this.quickSortToolStripMenuItem1_Click);
            // 
            // heapSortToolStripMenuItem1
            // 
            this.heapSortToolStripMenuItem1.Name = "heapSortToolStripMenuItem1";
            this.heapSortToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.heapSortToolStripMenuItem1.Text = "HeapSort";
            this.heapSortToolStripMenuItem1.Click += new System.EventHandler(this.heapSortToolStripMenuItem1_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mergeToolStripMenuItem.Text = "Merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // preenchimentoInicialToolStripMenuItem1
            // 
            this.preenchimentoInicialToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem1,
            this.decrescenteToolStripMenuItem1,
            this.aleatórioToolStripMenuItem1});
            this.preenchimentoInicialToolStripMenuItem1.Name = "preenchimentoInicialToolStripMenuItem1";
            this.preenchimentoInicialToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.preenchimentoInicialToolStripMenuItem1.Text = "Preenchimento Inicial";
            // 
            // crescenteToolStripMenuItem1
            // 
            this.crescenteToolStripMenuItem1.Name = "crescenteToolStripMenuItem1";
            this.crescenteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem1.Text = "Crescente";
            this.crescenteToolStripMenuItem1.Click += new System.EventHandler(this.crescenteToolStripMenuItem1_Click);
            // 
            // decrescenteToolStripMenuItem1
            // 
            this.decrescenteToolStripMenuItem1.Name = "decrescenteToolStripMenuItem1";
            this.decrescenteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem1.Text = "Decrescente";
            this.decrescenteToolStripMenuItem1.Click += new System.EventHandler(this.decrescenteToolStripMenuItem1_Click);
            // 
            // aleatórioToolStripMenuItem1
            // 
            this.aleatórioToolStripMenuItem1.Name = "aleatórioToolStripMenuItem1";
            this.aleatórioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aleatórioToolStripMenuItem1.Text = "Aleatório";
            this.aleatórioToolStripMenuItem1.Click += new System.EventHandler(this.aleatórioToolStripMenuItem1_Click);
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 - Métodos de Ordenação 2020/2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamanhoInicialDoVetorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem preenchimentoInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preenchimentoInicialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem1;
    }
}

